using Core.DataAccess;
using Core.Utilities.Results;
using Data.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContactService
    {
        Task<IResult> Add(Contact contact);
        Task<IResult> Update(Contact contact);
        Task Delete(Contact contact);
        Task<IDataResult<List<Contact>>> GetAll();
        Task<IDataResult<Contact>> GetById(int id);
    }
}
