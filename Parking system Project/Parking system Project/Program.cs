using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking_system_Project
{
    class Program
    {
        //Defining variables which will be used in different methods.
        public static int carnumber = 0, bikenumber = 0,Rickshawnum = 0;
        public static int vehicleplateno_in, vehicleplateno_out;
        public static int[] Rickshaw = new int[10];
        public static int[] carlineorder = new int [10];
        public static int[,] bikelineorder = new int [2,10];
        //this method will be called by the main method.
        //which will call other methods.
        //  In this method you will choose the functions which will be perfomed 
        //  by the system.
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t_________________________________________________");
            Console.WriteLine("\t\t|               *HYPERSTAR PARKING*             |");
            Console.WriteLine("\t\t|_______________________________________________|");
            Console.WriteLine("\t\t|                                               |");
            Console.WriteLine("\t\t|  1) FOR PARK A VEHICLE                        |");
            Console.WriteLine("\t\t|  2) NO OF VEHICLe PARKED                      |");
            Console.WriteLine("\t\t|  3) DISPLAY ORDER OF VEHICLE PARKED           |");
            Console.WriteLine("\t\t|  4) DEPARTURE OF A VEHICLE                    |");
            Console.WriteLine("\t\t|                                               |");
            Console.WriteLine("\t\t|  5) QUIT                                      |");
            Console.WriteLine("\t\t|_______________________________________________|");
            Console.WriteLine("\n\t\t======================");
            Console.Write("\t\t|Enter Your Choice : ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\t======================");
            
            switch (choice)
            {
                case 1:
                    {
                        one();
                        Menu();
                        break;
                    }
                case 2:
                    {
                        two();
                        break;
                    }
                case 3:
                    {
                        three();
                        break;
                    }
                case 4:
                    {
                       four();
                        break;
                    }
                case 5:
                    {
                        five();
                        break;
                    }
                default:
                    {

                        otherwise();
                        break;
                    }
            }
        }
        static void one()
        {
            Console.Clear();
            //This method is the second option.
            // This method will be used when the hardware will sense a vehicle in front of it.
            // It will ask vehicle type & it's Number plate.
            // If there is capacity to park it will allow the vehicle to park.
            // It will tell the system where Vehicle is parked.
            // It will print a Fee Challan for the driver.(Fee will be paid through Hardware).
            // If Fee is paid it will allow the vehicle to park.
            Console.WriteLine();
            Console.WriteLine("\n\t\t=========================");
            Console.WriteLine("\t\t|        ARRIVAL        |");
            Console.WriteLine("\t\t=========================");
            Console.WriteLine("\n\t\t=========================");
            Console.WriteLine("\t\t|For Car Press 1        |");
            Console.WriteLine("\t\t|For Bike Press 2       |");
            Console.WriteLine("\t\t|For Rickshaw Press 3   |");
            Console.WriteLine("\t\t=========================");
            Console.WriteLine("\n\t\t==============================");
            Console.Write("\t\t| Enter Your Vehicle Type : ");
            int vehicletype = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\t==============================");
            if (vehicletype == 1)
            {
                if (carnumber < 10)
                {
                    Console.WriteLine("\n\t\t=========================================");
                    Console.Write("\t\t| Enter Plate Number Of The Vehicle : ");
                    vehicleplateno_in = int.Parse(Console.ReadLine());
                    Console.WriteLine("\t\t=========================================");
                    if (vehicleplateno_in == 0)
                    {
                        Console.WriteLine("\n\t\t====================");
                        Console.WriteLine("\t\t| !!!WRONG INPUT!!!|");
                        Console.WriteLine("\t\t====================");
                        Console.ReadLine();
                        Menu();
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        if (vehicleplateno_in == carlineorder[i])
                        {
                            Console.WriteLine("\n\t\t==========================================");
                            Console.WriteLine("\t\t| !!!WRONG PLATE NO.!!!                  |");
                            Console.WriteLine("\t\t| !!!PLATE NO. ALREADY IN THE PARKING!!! |");
                            Console.WriteLine("\t\t==========================================");
                            Console.ReadLine();
                            Menu();
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        if (carlineorder[i] == 0)
                        {
                            Console.WriteLine("\n\t\t==============================================");
                            Console.Write("\t\t| Enter Hours You Will Park Your Vehicle : ");
                            double hours = double.Parse(Console.ReadLine());
                            Console.WriteLine("\t\t==============================================");
                            double Price = hours * 250;
                            Console.WriteLine("\n\t\t====================");
                            Console.WriteLine("\t\t|Parking Fees : " + Price + "|");
                            Console.WriteLine("\t\t====================");
                            carlineorder[i] = vehicleplateno_in;
                            carnumber++;
                            Console.ReadKey();
                            Menu();
                            break;
                        }
                        
                    }
                   
                }
                else if (carnumber >= 10)
                {
                    Console.WriteLine("\n\t\t===================================");
                    Console.WriteLine("\t\t| NO MORE SPACE FOR PARKING       |");
                    Console.WriteLine("\t\t| COME BACK LATER...!             |");
                    Console.WriteLine("\t\t===================================");
                    Console.ReadLine();
                    Menu();
                }
            }
            else if (vehicletype == 2)
            {
                Console.WriteLine("\n\t\t=========================================");
                Console.Write("\t\t| Enter Plate Number Of The Vehicle : ");
                vehicleplateno_in = int.Parse(Console.ReadLine());
                Console.WriteLine("\t\t=========================================");
                if (bikenumber < 20)
                {
                    if (vehicleplateno_in == 0)
                    {
                        Console.WriteLine("\n\t\t====================");
                        Console.WriteLine("\t\t| !!!WRONG INPUT!!!|");
                        Console.WriteLine("\t\t====================");
                        Console.ReadLine();
                        Menu();
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (vehicleplateno_in == bikelineorder[i,j] && vehicleplateno_in != 0)
                            {
                                Console.WriteLine("\n\t\t==========================================");
                                Console.WriteLine("\t\t| !!!WRONG PLATE NO.!!!                  |");
                                Console.WriteLine("\t\t| !!!PLATE NO. ALREADY IN THE PARKING!!! |");
                                Console.WriteLine("\t\t==========================================");
                                Console.ReadLine();
                                Menu();
                            }
                        }
                    }
                    Console.WriteLine();
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (bikelineorder[i,j] == 0)
                            {
                                Console.WriteLine("\n\t\t==============================================");
                                Console.Write("\t\t| Enter Hours You Will Park Your Vehicle : ");
                                double hours = double.Parse(Console.ReadLine());
                                Console.WriteLine("\t\t==============================================");
                                double Price = hours * 100;
                                Console.WriteLine("\n\t\t====================");
                                Console.WriteLine("\t\t|Parking Fees : " + Price + "|");
                                Console.WriteLine("\t\t====================");
                                bikelineorder[i,j] = vehicleplateno_in;
                                bikenumber++;
                                Console.ReadKey();
                                Menu();
                                break; 
                            }
                            
                        }
                    } 
                    
                }
                else if (bikenumber >= 20)
                {
                    Console.WriteLine("\n\t\t===================================");
                    Console.WriteLine("\t\t| NO MORE SPACE FOR PARKING       |");
                    Console.WriteLine("\t\t| COME BACK LATER...!             |");
                    Console.WriteLine("\t\t======================================");
                    Console.ReadKey();
                    Menu();
                }
            }
            if (vehicletype == 3)
            {
                if (Rickshawnum < 10)
                {
                    Console.WriteLine("\n\t\t=========================================");
                    Console.Write("\t\t| Enter Plate Number Of The Vehicle : ");
                    vehicleplateno_in = int.Parse(Console.ReadLine());
                    Console.WriteLine("\t\t=========================================");
                    if (vehicleplateno_in == 0)
                    {
                        Console.WriteLine("\n\t\t====================");
                        Console.WriteLine("\t\t| !!!WRONG INPUT!!!|");
                        Console.WriteLine("\t\t====================");
                        Console.ReadLine();
                        Menu();
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        if (vehicleplateno_in == Rickshaw[i])
                        {
                            Console.WriteLine("\n\t\t==========================================");
                            Console.WriteLine("\t\t| !!!WRONG PLATE NO.!!!                  |");
                            Console.WriteLine("\t\t| !!!PLATE NO. ALREADY IN THE PARKING!!! |");
                            Console.WriteLine("\t\t==========================================");
                            Console.ReadLine();
                            Menu();
                        }
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        if (Rickshaw[i] == 0)
                        {
                            Console.WriteLine("\n\t\t==============================================");
                            Console.Write("\t\t| Enter Hours You Will Park Your Vehicle : ");
                            double hours = double.Parse(Console.ReadLine());
                            Console.WriteLine("\t\t==============================================");
                            double Price = hours * 100;
                            Console.WriteLine("\n\t\t====================");
                            Console.WriteLine("\t\t|Parking Fees : " + Price + "|");
                            Console.WriteLine("\t\t====================");
                            Rickshaw[i] = vehicleplateno_in;
                            Rickshawnum++;
                            Console.ReadLine();
                            Menu();
                            break;
                        }
                    }
                }
                else if (Rickshawnum >= 10)
                {
                    Console.WriteLine("\n\t\t===================================");
                    Console.WriteLine("\t\t| NO MORE SPACE FOR PARKING       |");
                    Console.WriteLine("\t\t| COME BACK LATER...!             |");
                    Console.WriteLine("\t\t===================================");
                    Console.ReadKey();
                    Menu();
                }

               
            }
            else
            {
                Console.WriteLine("\n\t\t====================");
                Console.WriteLine("\t\t| !!!WRONG INPUT!!!|");
                Console.WriteLine("\t\t====================");
                Console.ReadLine();
                Menu();
            }
        }
        //This method is the 2nd option.
        //This method will tell a user the number of vehicles parked.
        //It will show number of cars and bikes parked.
        static void two()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t====================================");
            Console.WriteLine("\t\t|          VEHICLES PARKED         |");
            Console.WriteLine("\t\t====================================");
            Console.WriteLine("\n\t\t=====================================");
            Console.WriteLine("\t\t|      Total No. Of Vehicles : " + (bikenumber+carnumber+Rickshawnum)         +  "    |    ");
            Console.WriteLine("\t\t====================================");
            Console.WriteLine("\n\t\t======================================");
            Console.WriteLine("\t\t|        Cars Parked: "+carnumber + "             |");
            Console.WriteLine("\t\t|        Bikes Parked: "+ bikenumber + "            |");
            Console.WriteLine("\t\t|        Rickshaw Parked: " + Rickshawnum + "         |");
            Console.WriteLine("\t\t=====================================");
            Console.WriteLine();
            Console.Write("      Press any key .......");
            Console.ReadLine();
            Menu();
        }
        //This method is the 1st option.
        //This method will show the order of the vehicles in which they are prked.
        //It will represent the position of a vehicle in the Parking by using their plate no.
        static void three()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t==============================================");
            Console.WriteLine("\t\t|          ORDER OF VEHICLES PARKED          |");
            Console.WriteLine("\t\t==============================================");
            Console.WriteLine("\n__________________________________________________________________________________");
            Console.WriteLine("\n\t\t===============================");
            Console.WriteLine("\t\t|     CAR PARKING AREA        |");
            Console.WriteLine("\t\t===============================");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("    "+carlineorder[i]);
            }
            Console.WriteLine("\n\n\t\t================================");
            Console.WriteLine("\t\t|    BIKE PARKING AREA         |");
            Console.WriteLine("\t\t================================");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("     "+bikelineorder[i,j]);
                }
            }
            Console.WriteLine("\n\n\t\t====================================");
            Console.WriteLine("\t\t|    RICKSHAW PARKING AREA         |");
            Console.WriteLine("\t\t====================================");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("   " + Rickshaw[i]);
            }
            Console.WriteLine("\n\n____________________________________________________________________________________");
            Console.ReadLine();
            Menu();
        }
        //This method is the 4th option.
        //This method will be used when a vehicle is exitting.
        //This will ask the Vehicle's Plate no. & delete record of the vehicle.
        static void four()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t==============================================");
            Console.WriteLine("\t\t|               DEPARTURE                    |");
            Console.WriteLine("\t\t==============================================");
            Console.WriteLine("\n\t\t=========================");
            Console.WriteLine("\t\t|For Car Press 1        |");
            Console.WriteLine("\t\t|For Bike Press 2       |");
            Console.WriteLine("\t\t|For Rickshaw Press 3   |");
            Console.WriteLine("\t\t=========================");
            Console.WriteLine("\n\t\t==============================");
            Console.Write("\t\t| Enter Your Vehicle Type : ");
            int vehicletype = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\t==============================");
            if (vehicletype == 1)
            {
                Console.WriteLine("\n\t\t=========================================");
                Console.Write("\t\t| Enter Plate Number Of The Vehicle : ");
                vehicleplateno_out = int.Parse(Console.ReadLine());
                Console.WriteLine("\t\t=========================================");
                bool yesorno = false;
                for (int i = 0; i < 10; i++)
                {
                    if (carlineorder[i] == vehicleplateno_out)
                    {
                        carlineorder[i] = 0;
                        Console.WriteLine("\n\t\t===============================");
                        Console.WriteLine("\t\t|         GOOD BYE...!!       |");
                        Console.WriteLine("\t\t|      SEE YOU NEXT TIME      |");
                        Console.WriteLine("\t\t|      @HYPERSTAR PARKING     |");
                        Console.WriteLine("\t\t===============================");
                        carnumber--;
                        yesorno = true;
                        Console.ReadKey();
                        Menu();
                        
                    }
                    else if (vehicleplateno_out == 0)
                    {
                        Console.WriteLine("\n\t\t====================");
                        Console.WriteLine("\t\t| !!!WRONG INPUT!!!|");
                        Console.WriteLine("\t\t====================");
                        Console.ReadLine();
                        Menu();
                    }
                }
                if (yesorno == false)
                {
                    Console.WriteLine("\n\t\t=================================");
                    Console.WriteLine("\t\t|  WRONG PLATE N0 ENTERED       |");
                    Console.WriteLine("\t\t|  NO RECORD FOUND...!!!        |");
                    Console.WriteLine("\t\t|  PLZ ENTER CORRECT N0 PLATE   |");
                    Console.WriteLine("\t\t=================================");
                    Console.ReadLine();
                    Menu();
                }
            }
            else if (vehicletype == 2)
            {
                Console.WriteLine("\n\t\t=========================================");
                Console.Write("\t\t| Enter Plate Number Of The Vehicle : ");
                vehicleplateno_out = int.Parse(Console.ReadLine());
                Console.WriteLine("\t\t=========================================");
                bool yesorno = false;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (bikelineorder[i,j] == vehicleplateno_out)
                        {
                            bikelineorder[i,j] = 0;
                            Console.WriteLine("\n\t\t===============================");
                            Console.WriteLine("\t\t|         GOOD BYE...!!       |");
                            Console.WriteLine("\t\t|      SEE YOU NEXT TIME      |");
                            Console.WriteLine("\t\t|      @HYPERSTAR PARKING     |");
                            Console.WriteLine("\t\t===============================");
                            bikenumber--;
                            yesorno = true;
                            Console.ReadKey();
                            Menu();
                        }
                        else if (vehicleplateno_out == 0)
                        {
                            Console.WriteLine("\n\t\t====================");
                            Console.WriteLine("\t\t| !!!WRONG INPUT!!!|");
                            Console.WriteLine("\t\t====================");
                            Console.ReadLine();
                            Menu();
                        }
                    }
                }
                if (yesorno == false)
                {
                    Console.WriteLine("\n\t\t=================================");
                    Console.WriteLine("\t\t|  WRONG PLATE N0 ENTERED       |");
                    Console.WriteLine("\t\t|  NO RECORD FOUND...!!!        |");
                    Console.WriteLine("\t\t|  PLZ ENTER CORRECT N0 PLATE   |");
                    Console.WriteLine("\t\t=================================");
                    Console.ReadLine();
                    Menu();
                }

            }
            if (vehicletype == 3)
            {
                Console.WriteLine("\n\t\t=========================================");
                Console.Write("\t\t| Enter Plate Number Of The Vehicle : ");
                vehicleplateno_out = int.Parse(Console.ReadLine());
                Console.WriteLine("\t\t=========================================");
                if (vehicleplateno_out == 0)
                {
                    Console.WriteLine("\n\t\t====================");
                    Console.WriteLine("\t\t| !!!WRONG INPUT!!!|");
                    Console.WriteLine("\t\t====================");
                    Console.ReadLine();
                    Menu();
                }
                bool yesorno = false;
                for (int i = 0; i < 10; i++)
                {
                    if (Rickshaw[i] == vehicleplateno_out)
                    {
                        Rickshaw[i] = 0;
                        Console.WriteLine("\n\t\t===============================");
                        Console.WriteLine("\t\t|         GOOD BYE...!!       |");
                        Console.WriteLine("\t\t|      SEE YOU NEXT TIME      |");
                        Console.WriteLine("\t\t|      @HYPERSTAR PARKING     |");
                        Console.WriteLine("\t\t===============================");
                        Rickshawnum--;
                        yesorno = true;
                        Console.ReadKey();
                        Menu();
                    }
                }

                if (yesorno == false)
                {
                    Console.WriteLine("\n\t\t=================================");
                    Console.WriteLine("\t\t|  WRONG PLATE N0 ENTERED       |");
                    Console.WriteLine("\t\t|  NO RECORD FOUND...!!!        |");
                    Console.WriteLine("\t\t|  PLZ ENTER CORRECT N0 PLATE   |");
                    Console.WriteLine("\t\t=================================");
                    Console.ReadLine();
                    Menu();
                }
            }
            else
            {
                Console.WriteLine("\n\t\t====================");
                Console.WriteLine("\t\t| !!!WRONG INPUT!!!|");
                Console.WriteLine("\t\t====================");
                Console.ReadLine();
                Menu();
            }
        }
        // This method is the 5th Option.
        // This method will be used to shut down the system.
        // This will shutdown only if the Parking is empty.
        // Shutting down will require a Password which will be entered
        // by the operator only.
        // if two times password is entered wrong an alarm will ring

        static void five()
        {
            Console.Clear();
            if (carnumber == 0 && bikenumber == 0 && Rickshawnum == 0)
            {
                  Console.WriteLine("\n\t\t==========================================");
                  Console.Write("\t\t| Are You Sure You Want To Quit  (Y/N) : ");           
                  char yesorno = Convert.ToChar(Console.ReadLine());
                  Console.WriteLine("\t\t==========================================");
                  if (yesorno == 'Y')
                  {
                      Console.WriteLine("\n\t\t========================");
                      Console.WriteLine("\t\t|     GOOD BYE...!!    |");
                      Console.WriteLine("\t\t========================");
                      Console.ReadLine();
                  }
                  else if (yesorno == 'N')
                  {
                    Console.WriteLine("\n\t\t===========================");
                    Console.WriteLine("\t\t|    Okay Back To Menu    |");
                    Console.WriteLine("\t\t===========================");
                    Console.ReadLine();
                    Menu();
                  }
                 else
                 {
                    Console.WriteLine("\n\t\t====================");
                    Console.WriteLine("\t\t| !!!WRONG INPUT!!!|");
                    Console.WriteLine("\t\t====================");
                    Console.ReadLine();
                    Menu();
                 }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n\t\t=================================================");
                Console.WriteLine("\t\t| !!!There Are Still Vehicles In The Parking!!! |");
                Console.WriteLine("\t\t|            Can't Shutdown....!                |");
                Console.WriteLine("\t\t=================================================");
                Console.ReadLine();
                Menu();
            }
        }
        //This Method will run if a key other than the option is pressed
        static void otherwise()
        {
            Console.WriteLine("\n\t\t====================");
            Console.WriteLine("\t\t| !!!WRONG INPUT!!!|");
            Console.WriteLine("\t\t====================");
            Console.ReadLine();
            Menu();
        }
        static void Main(string[] args)
        {
            //After every restart of the system Password will be needed.
            //An operator of the system will start the system by using password.
            //Once program is started. Program will run until an operator shuts it down.
            Console.Clear();
            Console.WriteLine("\n\t\t==============================");
            Console.WriteLine("\t\t|Required Username & Password|");
            Console.WriteLine("\t\t==============================");
            int trys = 2;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\n\t\t=================================");
                Console.WriteLine("\t\t|You Have Only " + trys + " Tries For Login");
                Console.Write("\t\t|Enter Username : ");
                string username = Console.ReadLine();
                Console.Write("\t\t|Enter Password To Continue : ");
                string password = Console.ReadLine();
                Console.WriteLine("\t\t==================================");
                if (username == "user" && password == "pass")
                {
                    Console.WriteLine("\n\t\t===================");
                    Console.WriteLine("\t\t|LOGIN SUCCESSFULL|");
                    Console.WriteLine("\t\t===================");
                    Console.ReadKey();
                    Menu();         //calling a method which will redirect
                                    //to other methods
                    break;
                }
                else
                {
                    //If two times passwod is typed incorrect.
                    //An alarm will ring & shuts the system down.
                    trys--;
                    Console.WriteLine("\n\t\t=================================");
                    Console.WriteLine("\t\t|Invalid Username Or Password...|");
                    Console.WriteLine("\t\t=================================");
                    Console.WriteLine("\n\t\t=====================");
                    Console.WriteLine("\t\t|  " + trys + " Try Remaining  |");
                    Console.WriteLine("\t\t=====================");
                    if (trys == 0)
                    {
                        Console.Beep(1000,5000);
                        Console.WriteLine();
                    }
                    //if (trys == 1)
                    //{
                    //    Console.Clear();
                    //}
                }
            }
        }
    }
}
