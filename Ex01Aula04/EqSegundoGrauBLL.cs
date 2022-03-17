using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Aula04
{
    class EqSegundoGrauBLL
    {
        //nome
        public static void validaDados(EqSegundoGrau minhaeq)
        {
            Erro.setErro(false);

            //a
            if (minhaeq.getA().Length == 0)
            {
                Erro.setErro("O campo A é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    int.Parse(minhaeq.getA());
                }
                catch
                {
                    Erro.setErro("O campo A deve ser numérico ...");
                    return;
                }
            }



            //b
            if (minhaeq.getB().Length == 0)
            {
                Erro.setErro("O campo B é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    int.Parse(minhaeq.getB());
                }
                catch
                {
                    Erro.setErro("O campo B deve ser numérico ...");
                    return;
                }
            }



            //c
            if (minhaeq.getC().Length == 0)
            {
                Erro.setErro("O campo C é de preenchimento obrigatório...");
                return;
            }
            else
            {
                try
                {
                    int.Parse(minhaeq.getC());
                }
                catch
                {
                    Erro.setErro("O campo C deve ser numérico ...");
                    return;
                }
            }

            //DELTA
            if (float.Parse(minhaeq.calcDelta()) <= 0)
            {
                Erro.setErro("Sem raízes para delta negativo ou igual a 0");
                return;
            }
            

        }
    }
}