using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerbatoioAcqua
{
    public class Serbatoio
    {
        private int _nrseriale;
        private string _produttore;
        private string _modello;
        private int _lvacqua;
        private int _lvmin;
        private int _lvmax;
        public Lampada Lamp;
        public Sirena Siren;
        

        public Serbatoio(int nrseriale, string produttore, string modello, int lvacqua, int lvmin, int lvmax)
        {
            NrSeriale = nrseriale;
            Produttore = produttore;
            Modello = modello;
            LvMin = lvmin;
            LvMax = lvmax;
            LvAcqua = lvacqua;
            Lamp = new Lampada(nrseriale);
            Siren = new Sirena(nrseriale);
        }

        public Serbatoio(int nrseriale, string modello, int lvacqua, int lvmin, int lvmax) : this(nrseriale, "NA", modello, lvacqua, lvmin, lvmax)
        {

        }

        public Serbatoio(int nrseriale, int lvacqua, int lvmin, int lvmax) : this(nrseriale, "NA", "NA", lvacqua, lvmin, lvmax)
        {

        }

        public Serbatoio(int nrseriale) : this(nrseriale, "NA", "NA", 0, 0, 0)
        {

        }

        public Serbatoio() : this(0, "NA", "NA", 0, 0, 0)
        {

        }


        public int NrSeriale
        {
            set
            {
                if (value > 0)
                {
                    _nrseriale = value;
                }
                else
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _nrseriale;
            }
        }

        public string Produttore
        {
            set
            {
                if (value != null)
                {
                    _produttore = value;
                }
                else
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _produttore;
            }
        }

        public string Modello
        {
            set
            {
                if (value != null)
                {
                    _modello = value;
                }
                else
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _modello;
            }
        }

        public int LvAcqua
        {
            set
            {
                if (value >= LvMin && value <= LvMax)
                {
                    _lvacqua = value;
                }
                else
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _lvacqua;
            }
        }

        public int LvMax
        {
            set
            {
                if (value > LvMin)
                {
                    _lvmax = value;
                }
                else
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _lvmax;
            }
        }

        public int LvMin
        {
            set
            {
                if (value > 0)
                {
                    _lvmin = value;
                }
                else
                {
                    throw new Exception("Inesistente!");
                }
            }
            get
            {
                return _lvmin;
            }
        }

        public void Aggiungere(int acqua)
        {
            if(acqua > 0)
            {
                if (LvAcqua + acqua <= LvMax)
                {
                    LvAcqua = LvAcqua + acqua;
                    Segnalare();
                }
                else
                {
                    throw new Exception("SPAZIO del serbatoio INSUFFICENTE!");
                }
            }
            else
            {
                throw new Exception("Non puoi aggiungere una quantità negativa!");
            }
            
        }

        public void Rimuovere(int acqua)
        {
            if (acqua > 0)
            {
                if (LvAcqua - acqua >= LvMin)
                {
                    LvAcqua = LvAcqua - acqua;
                    Segnalare();
                }
                else
                {
                    throw new Exception("ACQUA nel serbatoio INSUFFICENTE!");
                }
            }
            else
            {
                throw new Exception("Non puoi rimuovere una quantità negativa!");
            }
        }

        public void Svuotare(Serbatoio Appoggio)
        {
            int delta = LvAcqua - LvMin;
            Appoggio.Aggiungere(delta);
            Rimuovere(delta);
        }


        int counter = 0;
        public void Segnalare()
        {
            int percentuale = (LvAcqua * 100) / LvMax;

            if(percentuale > 75)
            {
                Lamp.Stato = true;
                counter++;

                if (counter > 10)
                {
                    Siren.Stato = true;
                }
            }
            else
            {
                Lamp.Stato = false;
                counter = 0;
                Siren.Stato = false;
            }
        }
    }
}
