using System.Security.Cryptography;
namespace Gali
{ 
    class Gopi
    {
        static void Main(string[] args)
        {
            int sl,p1,rpl,p2,p3,ni,ads,p4,ads1,sln;
            string id1, id2,id3;
            Console.WriteLine("     WELCOME TO D MART          ");
            Console.WriteLine("which type of user : ");
            Console.WriteLine("1.Admin\n2.User");
            sl=Convert.ToInt32(Console.ReadLine());
            if(sl==1)
            {
                X: Console.WriteLine("admins only");
                Console.Write("your id     :");
                id1=Console.ReadLine();
                Console.WriteLine();
                Console.Write("your password:");
                p1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You want to reset your password:\n1.Yes\n2.No");
                rpl=Convert.ToInt32(Console.ReadLine());
                if(rpl==1)
                {
                    Console.Write("Enter you new password:");
                    p2= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("your password set successfully:");
                    p1 = p2;
                    Console.Write("your id     :");
                    id2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("your password:");
                    p3 = Convert.ToInt32(Console.ReadLine());
                    if(id2==id1 && p3==p1)
                    {
                        Console.Write("Welcome mr." + id2);
                        Console.WriteLine();
                        Console.WriteLine("           Admin dash board:            ");
                        Console.WriteLine("do you want to add the products:");
                        Console.WriteLine("1.Yes\n2.No");
                        ads=Convert.ToInt32(Console.ReadLine());
                        if (ads == 1)
                        {
                            Console.Write("how many products you want to be added:");
                            ni = Convert.ToInt32(Console.ReadLine());
                            string[] a = new string[ni];
                            int[] b = new int[ni];
                            Console.WriteLine();
                            for (int i = 0; i < ni; i++)
                            {
                                Console.Write("enter product id\'s:  ");
                                a[i] = Console.ReadLine();
                            }
                            for (int i = 0; i < ni; i++)
                            {
                                Console.Write("Enter product cost :");
                                b[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            for (int i = 0; i < ni; i++)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Product/cost    ||  " + a[i] + "  ||  " + b[i]);
                            }
                            Console.WriteLine("     WELCOME TO D MART          ");
                            Console.WriteLine("which type of user : ");
                            Console.WriteLine("1.Admin\n2.User");
                            sl = Convert.ToInt32(Console.ReadLine());
                            if (sl == 1)
                            {
                                goto X;
                            }
                            else if(sl==2)
                            {
                                int s = 0, h, d,q;string n,ph,e;
                                for (int i = 0; i < ni; i++)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Product/cost    ||  " + a[i] + "  ||  " + b[i]);
                                }
                                Console.WriteLine("How many products u want to buy:");
                                h = Convert.ToInt32(Console.ReadLine());
                                for (int i = 0; i < h; i++)
                                {
                                    if (h == 1)
                                    {
                                        Console.Write("quantity:");
                                        q = Convert.ToInt32(Console.ReadLine());
                                        s = s + (q*b[0]);
                                    }
                                    else if (h == 2)
                                    {
                                        Console.Write("quantity:");
                                        q = Convert.ToInt32(Console.ReadLine());
                                        s = s + (q * b[1]);
                                    }
                                    else if (h == 3)
                                    {
                                        Console.Write("quantity:");
                                        q = Convert.ToInt32(Console.ReadLine());
                                        s = s + (q * b[2]);
                                    }
                                    else if (h == 4)
                                    {
                                        Console.Write("quantity:");
                                        q = Convert.ToInt32(Console.ReadLine());
                                        s = s + (q * b[3]);
                                    }
                                    else if (h == 5)
                                    {
                                        Console.Write("quantity:");
                                        q = Convert.ToInt32(Console.ReadLine());
                                        s = s + (q * b[4]);
                                    }
                                }
                                Console.WriteLine("total bill" + s);
                                Console.WriteLine("Do you want continue:\n1.Yes\n2.No");
                                d = Convert.ToInt32(Console.ReadLine());
                                if (d == 1)
                                {
                                    Console.Write("Enter your name :");
                                    n = Console.ReadLine();
                                    Console.Write("Enter your ph no:");
                                    ph = Console.ReadLine();
                                    Console.Write("Enter your email:");
                                    e = Console.ReadLine();
                                    Console.WriteLine("             your total bill:     " + s);
                                    Console.WriteLine("             Thankyou for shopping       ");
                                }
                                else if (d == 2)
                                {
                                    Console.WriteLine("        Thankyou sir       ");
                                }
                                else
                                {
                                    Console.WriteLine("Enter valid option: ");
                                }
                            }
                        }
                        else if(ads==2)
                        {
                            Console.WriteLine("Thanks for visiting....have a good day");
                        }
                        else
                        {
                            Console.WriteLine("Enter valid option:");
                        }
                    }
                    else
                    {
                        Console.Write("please give valid terms");
                    }
                }
                else if(rpl==2)
                {
                    Console.WriteLine("         Welcome         ");
                    Console.Write("your id     :");
                    id3 = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("your password:");
                    p4 = Convert.ToInt32(Console.ReadLine());
                    if(id3==id1 && p4==p1)
                    {
                        Console.Write("Welcome mr." + id3);
                        Console.WriteLine();
                        Console.WriteLine("           Admin dash board:            ");
                        Console.WriteLine("do you want to add the products:");
                        Console.WriteLine("1.Yes\n2.No");
                        ads1 = Convert.ToInt32(Console.ReadLine());
                        if (ads1 == 1)
                        {
                            Console.Write("how many products you want to be added:");
                            ni = Convert.ToInt32(Console.ReadLine());
                            string[] a = new string[ni];
                            int[] b = new int[ni];
                            Console.WriteLine();
                            for (int i = 0; i < ni; i++)
                            {
                                Console.Write("enter product id\'s:  ");
                                a[i] = Console.ReadLine();
                            }
                            for (int i = 0; i < ni; i++)
                            {
                                Console.Write("Enter product cost :");
                                b[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            for (int i = 0; i < ni; i++)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Product/cost    ||  " + a[i] + "  ||  " + b[i]);
                            }
                            Console.WriteLine("     WELCOME TO D MART          ");
                            Console.WriteLine("which type of user : ");
                            Console.WriteLine("1.Admin\n2.User");
                            sl = Convert.ToInt32(Console.ReadLine());
                            if (sl == 1)
                            {
                                goto X;
                            }
                            else if (sl == 2)
                            {
                                int s = 0, h, d, q; string n, ph, e;
                                for (int i = 0; i < ni; i++)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Product/cost    ||  " + a[i] + "  ||  " + b[i]);
                                }
                                Console.WriteLine("How many products u want to buy:");
                                h = Convert.ToInt32(Console.ReadLine());
                                for (int i = 0; i < h; i++)
                                {
                                    if (h == 1)
                                    {
                                        Console.Write("quantity:");
                                        q = Convert.ToInt32(Console.ReadLine());
                                        s = s + (q * b[0]);
                                    }
                                    else if (h == 2)
                                    {
                                        Console.Write("quantity:");
                                        q = Convert.ToInt32(Console.ReadLine());
                                        s = s + (q * b[1]);
                                    }
                                    else if (h == 3)
                                    {
                                        Console.Write("quantity:");
                                        q = Convert.ToInt32(Console.ReadLine());
                                        s = s + (q * b[2]);
                                    }
                                    else if (h == 4)
                                    {
                                        Console.Write("quantity:");
                                        q = Convert.ToInt32(Console.ReadLine());
                                        s = s + (q * b[3]);
                                    }
                                    else if (h == 5)
                                    {
                                        Console.Write("quantity:");
                                        q = Convert.ToInt32(Console.ReadLine());
                                        s = s + (q * b[4]);
                                    }
                                }
                                Console.WriteLine("total bill" + s);
                                Console.WriteLine("Do you want continue:\n1.Yes\n2.No");
                                d = Convert.ToInt32(Console.ReadLine());
                                if (d == 1)
                                {
                                    Console.Write("Enter your name :");
                                    n = Console.ReadLine();
                                    Console.Write("Enter your ph no:");
                                    ph = Console.ReadLine();
                                    Console.Write("Enter your email:");
                                    e = Console.ReadLine();
                                    Console.WriteLine("             your total bill:     " + s);
                                    Console.WriteLine("             Thankyou for shopping       ");
                                }
                                else if (d == 2)
                                {
                                    Console.WriteLine("        Thankyou sir       ");
                                }
                                else
                                {
                                    Console.WriteLine("Enter valid option: ");
                                }
                            }
                        }
                        else if (ads1 == 2)
                        {
                            Console.WriteLine("Thanks for visiting....have a good day");
                        }
                        else
                        {
                            Console.WriteLine("Enter valid option:");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("enter valid option");
                }  
            }
            else if(sl==2)
            {
                int s = 0,b,item,n1,n2,n3,n4,n5,d;
                string n, ph, e;
                Console.WriteLine("user");
                
                string[] a=new string[5]{"item1   $10","item2   $20","item3   $30","item4   $40","item5   $50" };
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine(i + 1 + "   " + a[i]);
                }
                Console.Write("How many products you want to buy:");
                b=Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= b; i++)
                {
                    Console.Write("please select items:");
                    item = Convert.ToInt32(Console.ReadLine());
                    if (item == 1)
                    {
                        Console.Write("no.of quntity you want:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        s = s + (n1 * 10);
                    }
                    else if (item == 2)
                    {
                        Console.Write("no.of quntity you want:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        s = s + (n2 * 20);
                    }
                    else if (item == 3)
                    {
                        Console.Write("no.of quntity you want:");
                        n3 = Convert.ToInt32(Console.ReadLine());
                        s = s + (n3 * 30);
                    }
                    else if (item == 4)
                    {
                        Console.Write("no.of quntity you want:");
                        n4 = Convert.ToInt32(Console.ReadLine());
                        s = s + (n4 * 10);
                    }
                    else if (item == 5)
                    {
                        Console.Write("no.of quntity you want:");
                        n5 = Convert.ToInt32(Console.ReadLine());
                        s = s + (n5 * 10);
                    }
                    else
                    {
                        Console.WriteLine("please enter valid option:");
                    }
                }
                Console.WriteLine("total        " + s);
                Console.WriteLine("Do you want continue:\n1.Yes\n2.No");
                d=Convert.ToInt32(Console.ReadLine());
                if(d==1)
                {
                    Console.Write("Enter your name :");
                    n=Console.ReadLine();
                    Console.Write("Enter your ph no:");
                    ph = Console.ReadLine();
                    Console.Write("Enter your email:");
                    e = Console.ReadLine();
                    Console.WriteLine("             your total bill:     " + s);
                    Console.WriteLine("             Thankyou for shopping       ");

                }
                else if(d==2)
                {
                    Console.WriteLine("        Thankyou sir       ");
                }
                else
                {
                    Console.WriteLine("Enter valid option: ");
                }
            }
            else
            {
                Console.WriteLine("enter valid option");
            }
        }
    }
}