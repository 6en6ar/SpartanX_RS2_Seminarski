﻿using AutoMapper;
using ModelSpartanX;
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
    public class KupciService : IKupciService
    {
        private readonly SpartanXContext _context;
        private readonly IMapper _mapper;
        public KupciService( SpartanXContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ModelSpartanX.Kupci Authenticate(string username, string pass)
        {
            var user = _context.Kupcis.FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.LozinkaSalt, pass);

                if (hashedPass == user.LozinkaHash)
                {
                    return _mapper.Map<ModelSpartanX.Kupci>(user);
                }
            }

            return null;
        }
        public List<ModelSpartanX.Kupci> Get(ModelSpartanX.Search.KupciSearchObject request)
        {
            var query = _context.Korisnicis.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }

            var list = query.ToList();

            return _mapper.Map<List<ModelSpartanX.Kupci>>(list);
        }

        public ModelSpartanX.Kupci GetById(int id)
        {
            var entity = _context.Korisnicis.Find(id);

            return _mapper.Map<ModelSpartanX.Kupci>(entity);
        }

        public ModelSpartanX.Kupci Insert(ModelSpartanX.Requests.KupciInsertRequest req)
        {
            var kupac = _mapper.Map<Database.Kupci>(req);

            if (req.Password != req.PasswordPotvrda)
            {
                throw new Exception("Unesite isti password !");
            }

            kupac.LozinkaSalt = GenerateSalt();
            kupac.LozinkaHash = GenerateHash(kupac.LozinkaSalt, req.Password);
            _context.Kupcis.Add(kupac);
            _context.SaveChanges();

           
            _context.SaveChanges();

            return _mapper.Map<ModelSpartanX.Kupci>(kupac);
        }

        public ModelSpartanX.Kupci Update(int id, ModelSpartanX.Requests.KupciInsertRequest req)
        {
            var kupac = _context.Korisnicis.Find(id);
            _mapper.Map(req, kupac);
            _context.SaveChanges();
            return _mapper.Map<ModelSpartanX.Kupci>(kupac);
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
