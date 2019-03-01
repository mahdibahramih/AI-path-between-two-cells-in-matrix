using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int i_mabda = 7;
        public static int j_mabda = 0;
        public static int i_magsad = 0;
        public static int j_magsad = 9;

        public static int[,] faza = { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0 },
                                    { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
        public static int[,] faza2 = { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0 },
                                    { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
        public static int[,] faza3 = { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0 },
                                    { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
        public static int[,] faza4 = { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0 },
                                    { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };

        public static int[,] list_a = new int[6000, 7];
        public static int[,] list = new int[6000, 3];
        public static int[,] list_bfs = new int[6000, 7];
        public static int[,] list_dfs = new int[6000, 7];

        public static int end = 0;
        public static int top = 0;
        public static int ena_a = 0;
        public static int end_bfs = 0;
        public static int end_dfs = 0;
        public static int start_i = 8;
        public static int start_j = 1;




        static void Main(string[] args)
        {
            int selected;
            while (true)
            {
                Console.WriteLine("1- grady");
                Console.WriteLine("2- A* ");
                Console.WriteLine("3- bfs");
                Console.WriteLine("4- dfs");
                selected = Convert.ToInt32(Console.ReadLine());
                if (selected == 1)
                {
                    grady(i_mabda, j_mabda);
                }
                if (selected == 2)
                {
                    a_star(i_mabda, j_mabda);
                }
                if (selected == 3)
                {
                    bfs(i_mabda, j_mabda);
                }
                if (selected == 4)
                {
                    dfs(i_mabda, j_mabda);
                }

            }
        }








        static void grady(int i, int j)
        {
            add_to_list(i, j);
            while (i != 0 || j != 9)
            {
                if (i - 1 < 9 && i - 1 >= 0)
                    add_to_list(i - 1, j);

                if (j + 1 < 12 && j + 1 >= 0)
                    add_to_list(i, j + 1);

                if (i + 1 < 9 && i + 1 >= 0)
                    add_to_list(i + 1, j);

                if (j - 1 < 12 && j - 1 >= 0)
                    add_to_list(i, j - 1);
                int hyo = best();
                top = end;
                i = list[hyo, 0];
                j = list[hyo, 1];
                faza[i, j] = 6;

            }
            nemayesh();
        }
        public static void add_to_list(int i, int j)
        {
            list[end, 0] = i;
            list[end, 1] = j;
            list[end, 2] = hyorstic(i, j);
            end++;
        }
        public static int hyorstic(int i, int j)
        {

            if (j < 10)
            {
                return ((i - 1) + (10 - j));
            }
            else
            {
                return ((i - 1) + (j - 10));
            }

        }
        public static int best()
        {
            int max = top;
            for (int i = top; i < end; i++)
                if (list[max, 2] > list[i, 2])
                    max = i;



            return (max);


        }
        public static void nemayesh()
        {
            Console.Clear();
            for (int i = 0; i < 9; i++)
            {
                Console.Write("      ");
                for (int j = 0; j < 12; j++)
                {
                    if (faza[i, j] == 3 || /*faza[i,j] == 4 ||*/ faza[i, j] == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(faza[i, j]);
                        Console.Write("  ");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    Console.Write(faza[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
































        public static void a_star(int i, int j)
        {
            add_to_list_A(i, j, i, j, 1, 0);
            int m = 0;
            while (i != i_magsad || j != j_magsad)
            {
                if (j - 1 < 12 && j - 1 >= 0 && faza2[i, j - 1] != 1)
                    add_to_list_A(i, j - 1, i, j, 0, m);


                if (i + 1 < 9 && i + 1 >= 0 && faza2[i + 1, j] != 1)
                    add_to_list_A(i + 1, j, i, j, 0, m);

                if (j + 1 < 12 && j + 1 >= 0 && faza2[i, j + 1] != 1)
                    add_to_list_A(i, j + 1, i, j, 0, m);

                if (i - 1 < 9 && i - 1 >= 0 && faza2[i - 1, j] != 1)
                    add_to_list_A(i - 1, j, i, j, 0, m);



                m = best_A();
                i = list_a[m, 0];
                j = list_a[m, 1];
                list_a[m, 5] = 1;
            }
            for (int aaa = 0; aaa < ena_a; aaa++)
            {
                Console.Write("{0}   ", aaa);
                Console.WriteLine("{0}    {1}    {2}     {3}     {4}     {5}      {6}", list_a[aaa, 0], list_a[aaa, 1], list_a[aaa, 2], list_a[aaa, 3], list_a[aaa, 4], list_a[aaa, 5], list_a[aaa, 6]);
            }
            while (i != i_mabda || j != j_mabda)
            {
                i = list_a[m, 0];
                j = list_a[m, 1];
                faza2[i, j] = 6;
                m = list_a[m, 6];
            }
            nemayesha();







        }
        public static void add_to_list_A(int i, int j, int pi, int pj, int flag, int p_index)
        {
            int tekrari = 0;
            for (int p = 0; p < ena_a; p++)
            {
                if (i == list_a[p, 0])
                    if (j == list_a[p, 1])
                    {
                        tekrari = 1;
                        break;
                    }
            }
            // if (list_a[i, j] != 1)
            {
                if (tekrari == 0)
                {
                    list_a[ena_a, 0] = i;
                    list_a[ena_a, 1] = j;
                    list_a[ena_a, 2] = f(i, j);
                    list_a[ena_a, 3] = pi;
                    list_a[ena_a, 4] = pj;
                    list_a[ena_a, 5] = flag;
                    list_a[ena_a, 6] = p_index;
                    ena_a++;
                }
            }

        }
        public static int f(int i, int j)
        {
            int g = 0;
            {
                if (i < i_mabda)
                    g = ((i_mabda - i) + (j));
                else
                    g = ((i - i_mabda) + j);
            }
            int h = 0;
            if (j > j_magsad)
            {
                h = ((j - j_magsad) + (i));
            }
            else
            {
                h = (j_magsad - j) + i;

            }



            return h + g;
        }
        public static int best_A()
        {
            int index_max = 0;
            int max = 60000;
            for (int z = 1; z < ena_a; z++)
            {
                if (max > list_a[z, 2] && list_a[z, 5] == 0)
                {
                    max = list_a[z, 2];
                    index_max = z;
                }
            }
            return index_max;
        }
        public static void nemayesha()
        {
            Console.Clear();
            for (int i = 0; i < 9; i++)
            {
                Console.Write("      ");
                for (int j = 0; j < 12; j++)
                {
                    if (faza2[i, j] == 3 || /*faza[i,j] == 4 ||*/ faza2[i, j] == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(faza2[i, j]);
                        Console.Write("  ");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    Console.Write(faza2[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }


        }

























        public static void bfs(int i, int j)
        {

            add_to_list_bfs(i, j, -1, i, j, 1, 0);
            int m = 0;
            while (i != i_magsad || j != j_magsad)
            {
                if (i - 1 < 9 && i - 1 >= 0 && faza3[i - 1, j] != 1)
                    add_to_list_bfs(i - 1, j, list_bfs[m, 2], i, j, 0, m);

                if (i + 1 < 9 && i + 1 >= 0 && faza3[i + 1, j] != 1)
                    add_to_list_bfs(i + 1, j, list_bfs[m, 2], i, j, 0, m);

                if (j - 1 < 12 && j - 1 >= 0 && faza3[i, j - 1] != 1)
                    add_to_list_bfs(i, j - 1, list_bfs[m, 2], i, j, 0, m);

                if (j + 1 < 12 && j + 1 >= 0 && faza3[i, j + 1] != 1)
                    add_to_list_bfs(i, j + 1, list_bfs[m, 2], i, j, 0, m);











                m = less_deap();
                i = list_bfs[m, 0];
                j = list_bfs[m, 1];
                list_bfs[m, 5] = 1;
            }
            while (i != i_mabda || j != j_mabda)
            {
                i = list_bfs[m, 0];
                j = list_bfs[m, 1];
                faza3[i, j] = 6;
                m = list_bfs[m, 6];
            }
            nemayeshac();


        }



        public static void add_to_list_bfs(int i, int j, int deep, int ip, int jp, int flag, int index_p)
        {
            int tekrari = 0;
            for (int p = 0; p < end_bfs; p++)
            {
                if (i == list_bfs[p, 0])
                    if (j == list_bfs[p, 1])
                    {
                        tekrari = 1;
                        break;
                    }
            }
            if (tekrari == 0)
            {
                list_bfs[end_bfs, 0] = i;
                list_bfs[end_bfs, 1] = j;
                list_bfs[end_bfs, 2] = deep + 1;
                list_bfs[end_bfs, 3] = ip;
                list_bfs[end_bfs, 4] = jp;
                list_bfs[end_bfs, 5] = flag;
                list_bfs[end_bfs, 6] = index_p;
                end_bfs++;
            }
        }

        public static int less_deap()
        {
            int index_max = 0;
            int max = 60000;
            for (int z = 1; z < end_bfs; z++)
            {
                if (max > list_bfs[z, 2] && list_bfs[z, 5] == 0)
                {
                    max = list_bfs[z, 2];
                    index_max = z;
                }
            }
            return index_max;
        }


        public static void nemayeshac()
        {
            Console.Clear();
            for (int i = 0; i < 9; i++)
            {
                Console.Write("      ");
                for (int j = 0; j < 12; j++)
                {
                    if (faza3[i, j] == 3 || /*faza[i,j] == 4 ||*/ faza3[i, j] == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(faza3[i, j]);
                        Console.Write("  ");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    Console.Write(faza3[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }


        }



























        public static void dfs(int i, int j)
        {

            add_to_list_dfs(i, j, -1, i, j, 1, 0);
            int m = 0;
            while (i != i_magsad || j != j_magsad)
            {

                if (i + 1 < 9 && i + 1 >= 0 && faza4[i + 1, j] != 1   )
                    add_to_list_dfs(i + 1, j, list_dfs[m, 2], i, j, 0, m);

                if (j + 1 < 12 && j + 1 >= 0 && faza4[i, j + 1] != 1 )
                    add_to_list_dfs(i, j + 1, list_dfs[m, 2], i, j, 0, m);

                if (i - 1 < 9 && i - 1 >= 0 && faza4[i - 1, j] != 1 )
                    add_to_list_dfs(i - 1, j, list_dfs[m, 2], i, j, 0, m);



                if (j - 1 < 12 && j - 1 >= 0 && faza4[i, j - 1] != 1 )
                    add_to_list_dfs(i, j - 1, list_dfs[m, 2], i, j, 0, m);













                m = max_deep();
                i = list_dfs[m, 0];
                j = list_dfs[m, 1];
                list_dfs[m, 5] = 1;


            }
            while (i != i_mabda || j != j_mabda)
            {
                i = list_dfs[m, 0];
                j = list_dfs[m, 1];
                faza4[i, j] = 6;
                m = list_dfs[m, 6];
            }
            nemayeshad();


        }



        public static void add_to_list_dfs(int i, int j, int deep, int ip, int jp, int flag, int index_p)
        {
            int tekrari = 0;
            for (int p = 0; p < end_dfs; p++)
            {
                if (i == list_dfs[p, 0])
                    if (j == list_dfs[p, 1])
                    {
                        tekrari = 1;
                        break;
                    }
            }
            if (tekrari == 0)
            {
                list_dfs[end_dfs, 0] = i;
                list_dfs[end_dfs, 1] = j;
                list_dfs[end_dfs, 2] = deep + 1;
                list_dfs[end_dfs, 3] = ip;
                list_dfs[end_dfs, 4] = jp;
                list_dfs[end_dfs, 5] = flag;
                list_dfs[end_dfs, 6] = index_p;
                end_dfs++;
            }
        }

        public static int max_deep()
        {
            int index_max = 0;
            int max = 0;
            for (int z = 1; z < end_dfs; z++)
            {
                if (max < list_dfs[z, 2] && list_dfs[z, 5] == 0)
                {
                    max = list_dfs[z, 2];
                    index_max = z;
                }
            }
            return index_max;
        }


        public static void nemayeshad()
        {
            Console.Clear();
            for (int i = 0; i < 9; i++)
            {
                Console.Write("      ");
                for (int j = 0; j < 12; j++)
                {
                    if (faza4[i, j] == 3 || /*faza[i,j] == 4 ||*/ faza4[i, j] == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(faza4[i, j]);
                        Console.Write("  ");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    Console.Write(faza4[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }


        }

    }

}

