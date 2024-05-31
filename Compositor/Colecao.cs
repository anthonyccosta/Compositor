using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositor
{
    public class ColecaoProdutos : IComponent //implementa a interface IComponent e pode conter outros componentes
                                              //(sejam eles produtos individuais ou outras coleções de produtos
    {
        private List<IComponent> _componentes = new List<IComponent>();

        public void AdicionarComponente(IComponent componente)
        {
            _componentes.Add(componente);
        }

        public void MostrarPreco() //ele mostra os preços de todos os produtos na coleção componente
        {
            foreach (var componente in _componentes)
            {
                componente.MostrarPreco();
            }
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var componente in _componentes)
            {
                total += componente.CalcularTotal();
            }
            return total;
        }
    }
}
