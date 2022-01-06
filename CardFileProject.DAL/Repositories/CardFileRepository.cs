using CardFileProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFileProject.DAL.Repositories
{
    public class CardFileRepository : ICardFileRepository
    {
        private readonly CardFileContext _cardFileContext;

        public CardFileRepository(CardFileContext cardFileContext)
        {
            _cardFileContext = cardFileContext;
        }

        public CardFile Create(CardFile item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(CardFile item)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CardFile>> GetAll()
        {
            return await _cardFileContext.CardFiles.ToListAsync();
        }

        public CardFile GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CardFile Update(CardFile item)
        {
            throw new NotImplementedException();
        }
    }
}