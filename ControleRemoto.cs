using System;
namespace POO
{
	public class ControleRemoto : Controlador
	{
		private int volume;
		private bool ligado;
		private bool tocando;

		public ControleRemoto()
		{
			this.volume = 50;
			this.ligado = false;
			this.tocando = false;
		}

		public int getVolume()
        {
			return this.volume;
        }
		public void setVolume(int vol)
        {
			this.volume = vol;
        }

		public bool getLigado()
		{
			return this.ligado;
		}
		public void setLigado(bool situacao)
		{
			this.ligado = situacao;
		}

		public bool getTocando()
        {
			return this.tocando;
        }

		public void setTocando(bool estaTocando)
        {
			this.tocando = estaTocando;
        }

        ////////////////////
        ////////////////////

        public void ligar()
        {
            setLigado(true);
        }

        public void desligar()
        {
            setLigado(false);
        }

        public void abrirMenu()
        {
            Console.WriteLine("Está ligado?" + this.getLigado());
            Console.WriteLine("Está tocando?" + this.getTocando());
            Console.WriteLine("Volume: " + this.getVolume());
            for(var i = 0; i < this.getVolume(); i += 10)
            {
                Console.Write("|");
            }
        }

        public void fecharMenu()
        {
            Console.WriteLine("Fechando Menu!");
        }

        public void maisVolume()
        {
            if(this.getLigado() == true)
            {
                this.setTocando(true);
                this.setVolume(this.getVolume() + 10);
            }
        }

        public void menosVolume()
        {
            if(this.getLigado() == true)
            {
                this.setVolume(this.getVolume() - 10);
            }
        }

        public void ligarMudo()
        {
            this.setVolume(0);
            this.setTocando(false);
            Console.WriteLine("Mutado");
        }

        public void desligarMudo()
        {
            if(this.getVolume() == 0)
            {
                this.setVolume(50);
                this.setTocando(true);
                Console.WriteLine("Desmutado");
            }

        }

        public void play()
        {
            setLigado(true);
            setTocando(true);
            Console.WriteLine("Dando Play");
        }

        public void pause()
        {
            if(getLigado() == true && getTocando() == true)
            {
                setTocando(false);
                Console.WriteLine("Pausado.");
            }
        }
    }
}

