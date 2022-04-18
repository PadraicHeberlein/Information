using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    public class Message
    {
        private List<Symbol> payload;

        public Message()
        {
            payload = new List<Symbol>();
        }

        public Message(string theMessage)
        {
            payload = new List<Symbol>();
            int n = theMessage.Length;

            for (int i = 0; i < n; i++)
            {
                Symbol next = new Symbol(theMessage[i]);
                payload.Add(next);
            }
        }

        public bool Equals(Message other)
        {
            for (int i = 0; i < payload.Count; i++)
            {
                if (!payload[i].Equals(other.payload[i]))
                    return false;
            }

            return true;
        }
        public int Length() { return payload.Count; }
        public Symbol Get(int index) { return payload[index]; }
        public void Set(int index, Symbol s) { payload[index] = s; }
        public bool Contains(Symbol s) { return payload.Contains(s);  }
        public void Add(Symbol s) { payload.Add(s); }
    }

    public class MessageComparer : IEqualityComparer<Message>
    {
        public bool Equals(Message x, Message y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(Message obj)
        {
            throw new NotImplementedException();
        }
    }
}
