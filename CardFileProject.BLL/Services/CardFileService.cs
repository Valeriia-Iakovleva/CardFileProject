using CardFileProject.DAL.Models;
using CardFileProject.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFileProject.BLL.Services
{
    public class CardFileService : ICardFileService
    {
        private readonly ICardFileRepository _cardFileRepository;

        public CardFileService(ICardFileRepository cardFileRepository)
        {
            _cardFileRepository = cardFileRepository;
        }

        public async Task<IEnumerable<CardFile>> GetAll()
        {
            return await _cardFileRepository.GetAll();
        }
    }
}