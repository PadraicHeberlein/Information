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

        public Message(Message other)
        {
            payload = new List<Symbol>();
            int n = other.Length();

            for (int i = 0; i < n; i++)
            {
                Symbol next = new Symbol(other.payload[i]);
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
        public void Add(Symbol s) { payload.Add(s); }
        public void Add(char c) { payload.Add(new Symbol(c)); }
        public bool Contains(Symbol s) 
        {  
            return payload.Contains(s, new SymbolComparer());  
        }
        public bool Contains(char c)
        {
            return payload.Contains(new Symbol(c), new SymbolComparer());
        }
        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < payload.Count; i++)
                s += payload[i].ToString();

            return s;
        }
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
