using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerbatoioAcqua
{
    public class Lampada
    {
        private int _id;
        private bool _stato;

        public Lampada(int id, bool stato)
        {
            Id = id;
            Stato = stato;
        }

        public Lampada(int id) : this(id, false)
        {

        }

        public int Id
        {
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _id;
            }
        }

        public bool Stato
        {
            set
            {
                try
                {
                    _stato = value;
                }
                catch
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _stato;
            }
        }

    }

    public class Sirena
    {
        private int _id;
        private bool _stato;

        public Sirena(int id, bool stato)
        {
            Id = id;
            Stato = stato;
        }

        public Sirena(int id) : this(id, false)
        {

        }

        public int Id
        {
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _id;
            }
        }

        public bool Stato
        {
            set
            {
                try
                {
                    _stato = value;
                }
                catch
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _stato;
            }
        }
    }
}
