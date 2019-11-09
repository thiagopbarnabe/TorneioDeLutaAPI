using System;
using System.Collections.Generic;
using System.Text;

namespace TorneioDeLuta.Domain.AggregatesModel.JogoAggregate
{
    public class Jogo
    {
        private Lutador lutador1;
        private Lutador lutador2; 
        public Jogo(Lutador _lutador1, Lutador _lutador2)
        {
            this.lutador1 = _lutador1;
            this.lutador2 = _lutador2;
        }

        public ResultadoJogo Joga()
        {
            var porcentagemDeVitoriasLutador1 = Convert.ToInt32(Decimal.Divide(lutador1.Vitorias,lutador1.Lutas) * 100);
            var porcentagemDeVitoriasLutador2 = Convert.ToInt32(Decimal.Divide(lutador2.Vitorias,lutador2.Lutas) * 100);

            Lutador vencedor;
            Lutador perdedor;

            if(porcentagemDeVitoriasLutador1 == porcentagemDeVitoriasLutador2)
            {
                if(this.lutador1.ArtesMarciais.Count == this.lutador2.ArtesMarciais.Count)
                {
                    vencedor = this.lutador1.Lutas > this.lutador2.Lutas ? this.lutador1 : this.lutador2;
                    perdedor = this.lutador2.Lutas < this.lutador1.Lutas ? this.lutador2 : this.lutador1;
                }
                else
                {
                    vencedor = this.lutador1.ArtesMarciais.Count > this.lutador2.ArtesMarciais.Count ? this.lutador1 : this.lutador2;
                    perdedor = this.lutador2.ArtesMarciais.Count < this.lutador1.ArtesMarciais.Count ? this.lutador2 : this.lutador1;
                }
            }
            else
            {
                vencedor = porcentagemDeVitoriasLutador1 > porcentagemDeVitoriasLutador2 ? lutador1 : lutador2;
                perdedor = porcentagemDeVitoriasLutador2 < porcentagemDeVitoriasLutador1 ? lutador2 : lutador1;
            }
            

            return new ResultadoJogo(vencedor,perdedor);
        }
    }
}

