using System;
using System.Collections.Generic;
using System.Text;

public class Impressora
{
    public void ImprimirDocumento(IImprimivel item)
    {
        item.Imprimir();
    }
}
