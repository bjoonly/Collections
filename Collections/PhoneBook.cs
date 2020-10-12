using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class PhoneBook<T>
    {
        private Dictionary<T, T> phoneBook;
        public PhoneBook()
        {
            phoneBook = new Dictionary<T, T>();
        }
        public void Add(T name,T phoneNumber)
        {
            phoneBook.Add(name, phoneNumber);
        }
        public void Remove(T name)
        {
            if (!phoneBook.Remove(name))
                throw new Exception("Contact " + name + " not found.");
            Console.WriteLine($"Contact {name} successfully deleted.");
          
        }
        public void Edit(T name, T newPhoneNumber)
        {
            if(!phoneBook.ContainsKey(name))
                throw new Exception("Contact " + name + " not found.");
            phoneBook[name] = newPhoneNumber;
          
        }
        public T Search(T name)
        {
            if (!phoneBook.ContainsKey(name))
            throw new Exception("Contact " + name + " not found.");
            return phoneBook[name];
        }
        public void Show()
        {
            int count = 1;
            foreach (var item in phoneBook)
            {
                Console.WriteLine(count+" "+item.Key+" - "+item.Value);
                count++;
            }
        }
    }
}
