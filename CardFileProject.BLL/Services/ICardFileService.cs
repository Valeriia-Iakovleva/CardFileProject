using CardFileProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFileProject.BLL.Services
{
    public interface ICardFileService
    {
        Task<IEnumerable<CardFile>> GetAll();
    }
}