using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLines
{
    class Matrice
    {
        private int[,] mat, mat2;
        public int[,] pred;
        public int casute_libere;
        Random r;
        Queue<int> Q;

        /// <summary>
        /// Plaseaza (maxim) 3 bile fictive
        /// </summary>
        public void PuneBileFictive()
        {
            int i, j, tip, adaugat;
            if (casute_libere <= 3)
                adaugat = casute_libere;
            else
                adaugat = 3;
            while (adaugat > 0)
            {
                i = r.Next(0, 9);
                j = r.Next(0, 9);
                while (mat[i, j] != 0)
                {
                    i = r.Next(0, 9);
                    j = r.Next(0, 9);
                }
                tip = r.Next(1, 8);
                mat[i, j] = -tip;
                adaugat--;
            }
        }

        /// <summary>
        /// Plaseaza 3 bile initiale la inceputul unui joc nou
        /// </summary>
        private void PuneBileInitiale()
        {
            int i, j, tip; // pozitia bilei si tipul ei
            while(casute_libere>78)
            {
                i = r.Next(0, 9);
                j = r.Next(0, 9);
                if (mat[i, j] == 0)
                {
                    tip = r.Next(1, 8);
                    mat[i, j] = tip;
                    casute_libere--;
                }
            }
            PuneBileFictive();
        }

        /// <summary>
        /// Reseteaza matricea pentru un joc nou
        /// </summary>
        public void Initializare()
        {
            casute_libere = 81;
            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    mat[i, j] = 0;
                    mat2[i, j] = 0;
                }
            }
            PuneBileInitiale();
        }

        /// <summary>
        /// Constructor pentru o matrice de joc
        /// </summary>
        public Matrice()
        {
            mat = new int[9, 9];
            mat2 = new int[9, 9];
            pred = new int[9, 9];
            r = new Random();
            Q = new Queue<int>();
            Initializare();
        }

        public int this[int i, int j]
        {
            get
            {
                return mat[i, j];
            }
            set
            {
                mat[i, j] = value;
            }
        }

        /// <summary>
        /// Cauta daca exista drum liber intre (xstart, ystart) si (xfinal, yfinal)
        /// </summary>
        /// <param name="xstart"></param>
        /// <param name="ystart"></param>
        /// <param name="xfinal"></param>
        /// <param name="yfinal"></param>
        /// <returns></returns>
        public bool CautaDrum(int xstart, int ystart, int xfinal, int yfinal)
        {
            int i, j, tag, aux;
            aux = mat[xstart, ystart];
            mat[xstart, ystart] = 0;
            for (i = 0; i < 9; ++i)
            {
                for (j = 0; j < 9; ++j)
                {
                    pred[i, j] = -1;
                }
            }
            Q.Clear();
            Q.Enqueue(xfinal * 10 + yfinal);
            pred[xfinal, yfinal] = -2;
            while (Q.Count > 0)
            {
                tag = Q.Dequeue();
                i = tag / 10;
                j = tag % 10;
                // sus
                if (i - 1 >= 0 && mat[i - 1, j] <= 0 && pred[i - 1, j] == -1)
                {
                    pred[i - 1, j] = tag;
                    Q.Enqueue((i - 1) * 10 + j);
                }
                // jos
                if (i + 1 < 9 && mat[i + 1, j] <= 0 && pred[i + 1, j] == -1)
                {
                    pred[i + 1, j] = tag;
                    Q.Enqueue((i + 1) * 10 + j);
                }
                // dreapta
                if (j + 1 < 9 && mat[i, j + 1] <= 0 && pred[i, j + 1] == -1)
                {
                    pred[i, j + 1] = tag;
                    Q.Enqueue(i * 10 + j + 1);
                }
                // stanga
                if (j - 1 >= 0 && mat[i, j - 1] <= 0 && pred[i, j - 1] == -1)
                {
                    pred[i, j - 1] = tag;
                    Q.Enqueue(i * 10 + j - 1);
                }
            }
            mat[xstart, ystart] = aux;
            if (pred[xstart, ystart] == -1)
                return false;
            return true;
        }

        public bool Sunt5InLinie(int x, int y)
        {
            int i, contor, tip;
            bool gasit = false;
            tip = mat[x, y];
            // 1
            i = 0; contor = -1;
            while (x + i < 9 && y + i < 9 && mat[x + i, y + i] == tip)
            {
                contor++;
                i++;
            }
            i = 0;
            while (x - i >= 0 && y - i >= 0 && mat[x - i, y - i] == tip)
            {
                contor++;
                i++;
            }
            if (contor >= 5)
            {
                i--;
                while (0 <= x - i && x - i < 9 && 0 <= y - i && y - i < 9 && mat[x - i, y - i] == tip)
                {
                    mat[x - i, y - i] = -1000;
                    i--;
                }
                mat[x, y] = tip;
                gasit = true;
            }
            // 2
            i = 0; contor = -1;
            while (x + i < 9 && y - i >= 0 && mat[x + i, y - i] == tip)
            {
                contor++;
                i++;
            }
            i = 0;
            while (x - i >= 0 && y + i < 9 && mat[x - i, y + i] == tip)
            {
                contor++;
                i++;
            }
            if (contor >= 5)
            {
                i--;
                while (0 <= x - i && x - i < 9 && 0 <= y + i && y + i < 9 && mat[x - i, y + i] == tip)
                {
                    mat[x - i, y + i] = -1000;
                    i--;
                }
                mat[x, y] = tip;
                gasit = true;
            }
            // 3
            i = 0; contor = -1;
            while (x + i < 9 && mat[x + i, y] == tip)
            {
                contor++;
                i++;
            }
            i = 0;;
            while (x - i >= 0 && mat[x - i, y] == tip)
            {
                contor++;
                i++;
            }
            if (contor >= 5)
            {
                i--;
                while (0 <= x - i && x - i < 9 && mat[x - i, y] == tip)
                {
                    mat[x - i, y] = -1000;
                    i--;
                }
                mat[x, y] = tip;
                gasit = true;
            }
            // 4
            i = 0; contor = -1;
            while (y + i < 9 && mat[x, y + i] == tip)
            {
                contor++;
                i++;
            }
            i = 0;
            while (y - i >= 0 && mat[x, y - i] == tip)
            {
                contor++;
                i++;
            }
            if (contor >= 5)
            {
                i--;
                while (0 <= y - i && y - i < 9 && mat[x, y - i] == tip)
                {
                    mat[x, y - i] = -1000;
                    i--;
                }
                mat[x, y] = tip;
                gasit = true;
            }
            if (gasit)
                mat[x, y] = -1000;
            return gasit;
        }
    }
}
