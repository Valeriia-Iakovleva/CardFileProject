using CardFileProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFileProject.DAL.Repositories
{
    public interface ICardFileRepository
    {
        Task<IEnumerable<CardFile>> GetAll();

        CardFile Create(CardFile item);

        CardFile GetById(int id);

        CardFile Update(CardFile item);

        bool Delete(CardFile item);
    }
}