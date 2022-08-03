using Business.Abstract;
using Core.Utilities.Results;
using Data.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContactManager:IContactService
    {
        IContactRepository _contactRepository;

        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Task<IResult> Add(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<Contact>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Contact>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
