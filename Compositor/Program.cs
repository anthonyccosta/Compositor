using System;
using System.Collections.Generic;

public interface IComponent //define um conjunto de comportamentos -> MostrarPreco e CalcularTotal
                            //IComponent atua como o contrato comum que permite tratar tanto os produtos quanto as coleções de
                            //produtos de maneira uniforme.
{
    void MostrarPreco();
    decimal CalcularTotal();
}