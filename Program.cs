class homework2_3
{
    static void Main(string[] agrs)
    {
        while (true)
        {

            int a = 0;
            string plusorminus = Console.ReadLine();
            if (plusorminus == "+" || plusorminus == "-")
            {
                int row = int.Parse(Console.ReadLine());
                int coll = int.Parse(Console.ReadLine());
                float[,] A = new float[row, coll];
                float[,] B = new float[row, coll];
                
                
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < coll; j++)
                        {
                           
                            A[i, j] = float.Parse(Console.ReadLine());
                            
                        }
                    }
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < coll; j++)
                        {
                            B[i, j] =   float.Parse(Console.ReadLine());

                        }
                    }
                   if (plusorminus == "+")
                   {
                    for(int i = 0;i < row;i++)
                    {
                        for(int j = 0; j < coll;j++)
                        {
                        Console.WriteLine(A[i,j]+B[i,j]);
                        }
                    }
                   }
                   else
                   {
                    for(int i = 0;i < row;i++)
                    {
                        for(int j = 0; j < coll;j++)
                        {
                        Console.WriteLine(A[i,j]-B[i,j]);
                        }
                    }
                   }
                
                }
                else
                {
                    break;
                }

            }

        }
    }