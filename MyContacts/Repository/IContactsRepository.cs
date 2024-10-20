using System.Data;

namespace MyContacts.Repository
{
    interface IContactsRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int contactId);
        bool Insert(string name, string family, string mobile, string email, int age, string address);
        bool Update(int contactId, string name, string family, string mobile, string email, int age, string address);
        bool Delete(int contactId);
    }

}