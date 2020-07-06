using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Codenation.Challenge
{
    public class Country
    {           
        public State[] Top10StatesByArea()
        {   //Array que recebe todos os Estados
            State[] Estados = new State[27];
            Estados[0] = new State { Name = "Acre", Acronym = "AC", Area = 164123.040 };
            Estados[1] = new State { Name = "Alagoas", Acronym = "AL", Area = 27778.506 };
            Estados[2] = new State { Name = "Amapá", Acronym = "AP", Area = 142828.521 };
            Estados[3] = new State { Name = "Amazonas", Acronym = "AM", Area = 1559159.148 };
            Estados[4] = new State { Name = "Bahia", Acronym = "BA", Area = 564733.177 };
            Estados[5] = new State { Name = "Ceará", Acronym = "CE", Area = 148920.472 };   
            Estados[6] = new State { Name = "Distrito Federal", Acronym = "DF", Area = 5779.999 };
            Estados[7] = new State { Name = "Espírito Santo", Acronym = "ES", Area = 46095.583 };
            Estados[8] = new State { Name = "Goiás", Acronym = "GO", Area = 340111.783 };
            Estados[9] = new State { Name = "Maranhão", Acronym = "MA", Area = 331937.450 };
            Estados[10] = new State { Name = "Mato Grosso", Acronym = "MT", Area = 903366.192 };
            Estados[11] = new State { Name = "Mato Grosso do Sul", Acronym = "MS", Area = 357145.532 };
            Estados[12] = new State { Name = "Minas Gerais", Acronym = "MG", Area = 586522.122 };
            Estados[13] = new State { Name = "Pará", Acronym = "PA", Area = 1247954.666 };
            Estados[14] = new State { Name = "Paraíba", Acronym = "PB", Area = 56585.000 };
            Estados[15] = new State { Name = "Paraná", Acronym = "PR", Area = 199307.922 };
            Estados[16] = new State { Name = "Pernambuco", Acronym = "PE", Area = 98311.616 };
            Estados[17] = new State { Name = "Piauí", Acronym = "PI", Area = 251577.738 };
            Estados[18] = new State { Name = "Rio de Janeiro", Acronym = "RJ", Area = 43780.172 };
            Estados[19] = new State { Name = "Rio Grande do Norte", Acronym = "RN", Area = 52811.047 };
            Estados[20] = new State { Name = "Rio Grande do Sul", Acronym = "RS", Area = 281730.223 };
            Estados[21] = new State { Name = "Rondônia", Acronym = "RO", Area = 237590.547 };
            Estados[22] = new State { Name = "Roraima", Acronym = "RR", Area = 224300.506 };
            Estados[23] = new State { Name = "Santa Catarina", Acronym = "SC", Area = 95736.165 };
            Estados[24] = new State { Name = "São Paulo", Acronym = "SP", Area = 248222.362 };
            Estados[25] = new State { Name = "Sergipe", Acronym = "SE", Area = 21915.116 };
            Estados[26] = new State { Name = "Tocantins", Acronym = "TO", Area = 277720.520 };

            //Organizacao dos Estados por area
            for (int i = 0; i < Estados.Length; i++)
            {
                int posicaoMaiorEstados = i;

                for (int j = i + 1; j < Estados.Length; j++)
                {
                    if (Estados[posicaoMaiorEstados].Area < Estados[j].Area)
                    {
                        posicaoMaiorEstados = j;
                    }
                }

                State aux = Estados[i];
                Estados[i] = Estados[posicaoMaiorEstados];
                Estados[posicaoMaiorEstados] = aux;
            }

            //Array que recebe os 10 maiores Estados
            State[] maioresEstados = new State[10];

            for (int i =0; i < 10; i++)
            {
                maioresEstados[i] = Estados[i];
            }

            return maioresEstados;
        }
    }
}
