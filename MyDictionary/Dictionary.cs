using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<Name, Id>
    {
        Name[] names;
        Id[] ids;
        public MyDictionary()
        {
            names = new Name[0];
            ids = new Id[0];
        }
        public void Add(Name name, Id id)
        {
            Name[] tempNames = names;
            Id[] tempIds = ids;

            names = new Name[names.Length + 1];
            ids = new Id[ids.Length+1];

            for (int i = 0; i < tempNames.Length; i++)
            {
                names[i] = tempNames[i];
            }
            for (int i = 0; i < tempIds.Length; i++)
            {
                ids[i] = tempIds[i];
            }

            names[names.Length - 1] = name;
            ids[ids.Length - 1] = id;
        }

        public void List()
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("İsim: "+names[i]+", Kimlik No: "+ids[i]);
            }
        }
        
        private int Count
        {
            get { return names.Length; }
        }
    }
}
