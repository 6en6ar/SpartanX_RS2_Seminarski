using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SpartanX.Database;
using SpartanX.Model.Requests;
using SpartanX.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly SpartanXContext _context;
        private readonly IMapper _mapper;
        public KorisniciService(SpartanXContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Korisnici> Get(KorisniciSearchObject request)
        {
            var query = _context.Korisnicis.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnicis.Find(id);

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Insert(KorisniciInsertRequest req)
        {
            var korisnik = _mapper.Map<Database.Korisnici>(req);

            if (req.Password != req.PasswordPotvrda)
            {
                throw new Exception("Unesite isti password !");
            }

            korisnik.LozinkaSalt = GenerateSalt();
            korisnik.LozinkaHash = GenerateHash(korisnik.LozinkaSalt, req.Password);
            _context.Korisnicis.Add(korisnik);
            _context.SaveChanges();

            foreach (var uloga in req.Uloge)
            {
                Database.KorisnikUloge korisniciUloge = new Database.KorisnikUloge();
                korisniciUloge.KorisnikId = korisnik.KorisnikId;
                korisniciUloge.UlogaId = uloga;
                korisniciUloge.Datum = DateTime.Now;
                _context.KorisnikUloges.Add(korisniciUloge);
            }
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(korisnik);
        }

        public Model.Korisnici Update(int id, KorisniciInsertRequest req)
        {
            var korisnik = _context.Korisnicis.Find(id);
            _mapper.Map(req, korisnik);
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnici>(korisnik);
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

        public async Task<Model.Korisnici> Authenticate(string username, string password)
        {
            var kor = await _context.Korisnicis.Include("KorisnikUloges.Uloga").FirstOrDefaultAsync(x => x.KorisnickoIme == username);
            if(kor == null)
            {
                throw new Exception("Pogresan username ili password!");
            }
            //generate hash
            var hash = GenerateHash(kor.LozinkaSalt, password);
            if (hash != kor.LozinkaHash)
            {
                throw new Exception("Pogresan username ili password!");
            }
            return _mapper.Map<Model.Korisnici>(kor);
        }

    }
}
