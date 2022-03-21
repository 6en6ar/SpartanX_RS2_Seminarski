using AutoMapper;
using ModelSpartanX.Requests;
using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class NarudzbeService : INarudzbeService
    {
        private readonly SpartanXContext _context;
        private readonly IMapper _mapper;
        public NarudzbeService(SpartanXContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ModelSpartanX.Narudzbe> Get(object search = null)
        {
            var DBset = _context.Set<Database.Narudzbe>().AsQueryable();
            var lista = DBset.ToList();
            var modeli = _mapper.Map<List<ModelSpartanX.Narudzbe>>(DBset);
            return modeli;
        }
        public List<ModelSpartanX.Narudzbe> GetNarudzbe(string username, string password, object search = null)
        {
            var user = _context.Kupcis.FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.LozinkaSalt, password);

                if (hashedPass == user.LozinkaHash)
                {
                    var DBset = _context.Set<Database.Narudzbe>().AsQueryable();
                    var lista = DBset.ToList();
                    var modeli = _mapper.Map<List<ModelSpartanX.Narudzbe>>(DBset);
                    return modeli;
                }
            }

            return null;

        }

        public ModelSpartanX.Narudzbe GetById(int id)
        {
            var entity = _context.Narudzbes.Find(id);

            return _mapper.Map<ModelSpartanX.Narudzbe>(entity);
        }

        public void Insert(NarudzbeInsertRequest request)
        {
            

            Database.Narudzbe nar = new Database.Narudzbe();

            nar.BrojNarudzbe = request.BrojNarudzbe;
            nar.DatumNarudzbe = request.DatumNarudzbe;

            if (request.IznosBezPdv > 0)
            {
                nar.IznosBezPdv = request.IznosBezPdv;
            }
            if (request.IznosSaPdv > 0)
            {
                nar.IznosSaPdv = request.IznosSaPdv;
            }
            nar.Otkazano = request.Otkazano;
            nar.Status = request.Status;
            nar.KupacId = request.KupacId;
            nar.SkladisteId = request.SkladisteId;

            _context.Narudzbes.Add(nar);
            _context.SaveChanges();
            foreach (var item in request.stavke)
            {

                Database.NarudzbaStavke stavka = new Database.NarudzbaStavke();
                stavka.NarudzbaId = nar.NarudzbaId;
                stavka.Popust = item.Popust;
                stavka.Kolicina = item.Kolicina;
                stavka.Cijena = item.Cijena;
                stavka.ProizvodId = item.ProizvodId;


                _context.NarudzbaStavkes.Add(stavka);
                _context.SaveChanges();
            }


            //var narudzba = _mapper.Map<Database.Narudzbe>(request);

            //_context.Narudzbes.Add(narudzba);
            //_context.SaveChanges();
            //return _mapper.Map<ModelSpartanX.Narudzbe>(nar);
        }
        public void InsertNarudzba(NarudzbeInsertRequest request, string username, string password)
        {
            var user = _context.Kupcis.FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.LozinkaSalt, password);

                if (hashedPass == user.LozinkaHash)
                {
                    //code here
                    Database.Narudzbe nar = new Database.Narudzbe();

                    nar.BrojNarudzbe = request.BrojNarudzbe;
                    nar.DatumNarudzbe = request.DatumNarudzbe;

                    if (request.IznosBezPdv > 0)
                    {
                        nar.IznosBezPdv = request.IznosBezPdv;
                    }
                    if (request.IznosSaPdv > 0)
                    {
                        nar.IznosSaPdv = request.IznosSaPdv;
                    }
                    nar.Otkazano = request.Otkazano;
                    nar.Status = request.Status;
                    nar.KupacId = request.KupacId;
                    nar.SkladisteId = request.SkladisteId;

                    _context.Narudzbes.Add(nar);
                    _context.SaveChanges();
                    foreach (var item in request.stavke)
                    {

                        Database.NarudzbaStavke stavka = new Database.NarudzbaStavke();
                        stavka.NarudzbaId = nar.NarudzbaId;
                        stavka.Popust = item.Popust;
                        stavka.Kolicina = item.Kolicina;
                        stavka.Cijena = item.Cijena;
                        stavka.ProizvodId = item.ProizvodId;


                        _context.NarudzbaStavkes.Add(stavka);
                        _context.SaveChanges();
                    }
                    //return _mapper.Map<ModelSpartanX.Narudzbe>(nar);
                }
            }
            
            //return null;

            //var narudzba = _mapper.Map<Database.Narudzbe>(request);

            //_context.Narudzbes.Add(narudzba);
            //_context.SaveChanges();
            //return _mapper.Map<ModelSpartanX.Narudzbe>(nar);
        }


        public ModelSpartanX.Narudzbe Update(int id, NarudzbeUpdateRequest request)
        {
            var narudzba = _context.Narudzbes.Find(id);
            _mapper.Map(request, narudzba);
            _context.SaveChanges();
            return _mapper.Map<ModelSpartanX.Narudzbe>(narudzba);
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
