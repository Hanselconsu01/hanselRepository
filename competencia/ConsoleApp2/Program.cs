
using System;
 

class Program
{
    private static void Main(string[] args)
    {
        // PROGRAMA QUE SELECCIONE 2 ESTUDIANTES, UNO DEBE SALIR QUE DEBE PROGRAMAR PARA LA CLASE
        // Y EL OTRO SALE QUE DEBE DECIR QUE PROGRAMA HARA EL QUE VA A PROGRAMAR
        // LAS PERSONAS QUE YA PARTICIPARON NO PUEDEN VOLVER A SALIR
        //2 LISTAS UNA PARA LOS QUE NO HAN PARTICIPADO
        // Y LA OTRA PARA LOS QUE YA PARTICIPARON, ESTOS PARA QUE ELLOS NO VUELVAN A SALIR.

        int estudiante1, estudiante2;

        // AQUI SON LAS STRINGS DE LOS DIBUJOS
        string BIENVENIDOMENU, CARITAFELIZMENU, CORAZONFELIZTEMP, CARITATRISTETEMP, CORAZONTRISTEMENU;

        BIENVENIDOMENU = @"

 ██████  ██ ███████ ███    ██ ██    ██ ███████ ███    ██ ██ ██████   ██████       █████      ██       █████       ██████  ██████  ███    ███ ██████  ███████ ████████ ███████ ███    ██  ██████ ██  █████  
 ██   ██ ██ ██      ████   ██ ██    ██ ██      ████   ██ ██ ██   ██ ██    ██     ██   ██     ██      ██   ██     ██      ██    ██ ████  ████ ██   ██ ██         ██    ██      ████   ██ ██      ██ ██   ██ 
 ██████  ██ █████   ██ ██  ██ ██    ██ █████   ██ ██  ██ ██ ██   ██ ██    ██     ███████     ██      ███████     ██      ██    ██ ██ ████ ██ ██████  █████      ██    █████   ██ ██  ██ ██      ██ ███████ 
 ██   ██ ██ ██      ██  ██ ██  ██  ██  ██      ██  ██ ██ ██ ██   ██ ██    ██     ██   ██     ██      ██   ██     ██      ██    ██ ██  ██  ██ ██      ██         ██    ██      ██  ██ ██ ██      ██ ██   ██ 
 ██████  ██ ███████ ██   ████   ████   ███████ ██   ████ ██ ██████   ██████      ██   ██     ███████ ██   ██      ██████  ██████  ██      ██ ██      ███████    ██    ███████ ██   ████  ██████ ██ ██   ██ 
                                                                                                                                                                                                          
                                                                                                                                                                                                          
  ";

        CARITAFELIZMENU = @"        

░░███████░░░░░░░░░░███▒▒▒▒▒▒▒▒███
░░█▒▒▒▒▒▒█░░░░░░░███▒▒▒▒▒▒▒▒▒▒▒▒▒███
░░░█▒▒▒▒▒▒█░░░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██
░░░░█▒▒▒▒▒█░░░██▒▒▒▒▒██▒▒▒▒▒▒██▒▒▒▒▒███
░░░░░█▒▒▒█░░░█▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒▒██
░░░█████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██
░░░█▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒██
░██▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒██▒▒▒▒▒▒▒▒▒▒██▒▒▒▒██
██▒▒▒███████████▒▒▒▒▒██▒▒▒▒▒▒▒▒██▒▒▒▒▒██
█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒████████▒▒▒▒▒▒▒██
██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██
░█▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██
░██▒▒▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
░░████████████░░░█████████████████
";

        CORAZONFELIZTEMP = @"
░░░░░██▓▓▓▓▓▓▒▓▓██░░▓█▓▓▓▓▒░▒▒▓▓██
░░░██▓▓▓▓▓▓▓▓▓▒░▓▓███▓▓▓▓▓▒▒▒░░▒▓▓█
░░██▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓█▓▓▓▓▓▓▓▓▓▓▒░░▓▓█
░▒█▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓██▓▓▓▓▓▓▓▓▓▒░░▓▓█
░█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒░▒▓█
░█▓▓▓▓▓▓▓▓▓▓▓▓████░████▓▓▓▓▓▓▓▓▓▒░░▓██
█▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░░░██▓▓▓▓▓▓▓▓▓░░▓▓█
█▓▓▓▓▓▓▓▓▓▓▓▓▓░░█░░░█░░▓▓▓▓▓▓▓▓▓▓▒░▓▓█▒
█▓▓▓▓▓▓▓▓▓▓▓▓▓░█▒█░█▒█░▓▓▓▓▓▓▓▓▓▓▒▒▓▓█▒
█▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▒▒▓██▒
█▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▒██░░░▓▓▓▓▓▓▓▓▓▓▓▒▓▓█▓▒
░█▓▓▓▓▓▓▓▓▓▓▓▓▓▓████▓▓▓▓▓▓▓▓▓▓▓▓▓▒▓▓█▓▒
░█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▒
░░█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▒
░░█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓███▓▓▓▓▓▓▓▓▓▓█▓▒
░░░█▓▓▓▓▓▓▓▓▓██▓▓▓▓█████▓▓▓▓▓▓▓▓▓▓█▓▒
░░░░█▓▓▓▓▓▓▓▓██████████▓▓▓▓▓▓▓▓▓▓██▓▒
░░░░▓█▓▓▓▓▓▓▓▓██▒▒▓▒▒█▓▓▓▓▓▓▓▓▓▓██▓▒
░░░░░░█▓▓▓▓▓▓▓▓██▒▒▒█▓▓▓▓▓▓▓▓▓▓██▓▒
░░░░░░░██▓▓▓▓▓▓▓▓███▓▓▓▓▓▓▓▓▓▓██▓▒
░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▒
░░░░░░░░░░█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▒
░░░░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓██▓▒
░░░░░░░░░░░░░██▓▓▓▓▓▓▓▓▓█▓▒
░░░░░░░░░░░░░░░██▓▓▓▓▓██▓▒
░░░░░░░░░░░░░░░░░█▓▓██▓▒
░░░░░░░░░░░░░░░░░░░█▓▒
";


        CORAZONTRISTEMENU =
            @"
──────▓▓▒▒▒▒▒▒▒▓▓────────▒▒░░░░░░▒▒
────▓▓▒▒▒▒▒▒▒▒▒▒▒▓▓────▒▒░░░░░░░░░▒▒▒
───▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒░░░░░░░░░░░░░░▒
──▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░▒
──▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░▒
─▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░░▒
▓▓▒▒▒▒▒▒░░░░░░░░░░░▒▒░░▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒
▓▓▒▒▒▒▒▒▀▀▀▀▀███▄▄▒▒▒░░░▄▄▄██▀▀▀▀▀░░░░░░▒
▓▓▒▒▒▒▒▒▒▄▀████▀███▄▒░▄████▀████▄░░░░░░░▒
▓▓▒▒▒▒▒▒█──▀█████▀─▌▒░▐──▀█████▀─█░░░░░░▒
▓▓▒▒▒▒▒▒▒▀▄▄▄▄▄▄▄▄▀▒▒░░▀▄▄▄▄▄▄▄▄▀░░░░░░░▒
─▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░░▒
──▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░░▒
───▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▀▀▀░░░░░░░░░░░░░░▒
────▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░▒▒
─────▓▓▒▒▒▒▒▒▒▒▒▒▄▄▄▄▄▄▄▄▄░░░░░░░░▒▒
──────▓▓▒▒▒▒▒▒▒▄▀▀▀▀▀▀▀▀▀▀▀▄░░░░░▒▒
───────▓▓▒▒▒▒▒▀▒▒▒▒▒▒░░░░░░░▀░░░▒▒
────────▓▓▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░▒▒
──────────▓▓▒▒▒▒▒▒▒▒▒░░░░░░░░▒▒
───────────────▓▓▒▒▒▒░░░░▒▒
────────────────▓▓▒▒▒░░░▒▒
──────────────────▓▓▒░▒▒
───────────────────▓▒░▒
────────────────────▓▒
";
        CARITATRISTETEMP = @"
─────────────███████████████────────────
──────────████▒▒▒▒▒▒▒▒▒▒▒▒▒████─────────
────────███▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███───────
───────██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███─────
──────██▒▒▒▒▒▒▒▒▒▒██▒▒▒▒███████▒▒▒██────
─────██▒▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒██▒▒▒██───
────██▒▒██▒▒▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒▒███▒▒██──
───██▒▒▒▒▒████▒▒▒▒██▒▒▒██▒▒▒▒▒▒▒▒██▒▒█──
───█▒▒▒▒▒▒▒▒▒▒▒███░█▒▒▒█░███▒▒▒▒▒▒▒▒▒█──
───█▒▒▒▒▒██████░░░░█▒▒▒█░░░░██████▒▒▒█──
───█▒▒▒▒▒▒▒█░░░░▓▓██▒▒▒██▓▓░░░░█▒▒▒▒▒█──
───█▒▒▒▒▒▒▒▒██████▒▒▒▒▒▒▒██████▒█▒▒▒▒█──
───█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█──
───█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█░█▒▒▒█──
───██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█░█▒▒██──
────██▒▒▒▒▒▒▒▒▒▒▒████████▒▒▒▒▒▒██▒▒██───
─────██▒▒▒▒▒▒█████▒▒▒▒▒▒█████▒▒▒▒▒██────
──────██▒▒▒███▒▒▒▒▒████▒▒▒▒▒███▒▒██─────
───────███▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒██──────
─────────███▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███───────
───────────█████▒▒▒▒▒▒▒▒▒██████─────────
───────────────████████████─────────────";























        //INICIO DEL CODIGO DEL PROGRAMA, INICIALIZADO POR UN BUCLE QUE COMIENZA EN FALSE


        string[] estudiantes = new string[20] {
    "(0) Bryant Lerbours Reynoso","(1) Daniel Abdiery Hernandez Beras",
    "(2) Dayely Maria Santana Mateo","(3) Darik Enmmanuel Diaz Alcantara","(4) Federico Alejandro Garcia Tavarez",
    "(5) Felix Manuel Quezada Navarro","(6) Gary Alexander Campusano Paredes","(7) Jack Michael Gomez Alfonso",
    "(8) Jaylina Lucia Tavares Rodriguez","(9) Jinnet Altagracia Duvernay Reyes","(10) Jose Enrique Tejada Ramirez",
    "(11) Jose Hector Tavares Sandoval","(12) Juan Enmmanuel Lopez Aramboles","(13) Luis Jorge Mendez Tavares",
    "(14) Osiris Omarlin Matos Moreta","(15) Paul Enmmanuel Garcia Devers","(16) Rayni Steben Diaz Quezada ",
    "(17) Starling Enmmanuel Jacobo Mejia","(18) Wandry Martinez Mendez","(19) Yoshua Perez Musseb "};




        // ARRAY DONDE LOS QUE YA PROGRAMARON SE ALMACENAN TEMPORALMENTE MIENTRAS EL PROGRAMA SE EJECUTA.

        string[] estudianteParticipo = new string[20];


        bool bucle = true;
        while (bucle)
        {


            //Este IF se encarga de la musica del menu
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@$"{BIENVENIDOMENU}");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($@"

                                                                    1 PARA MOSTRAR LISTA DE PARTICIPANTES.
                                                                    2 PARA IR DIRECTAMENTE A LA COMPETENCIA.  
                                                                    3 PARA USAR UN TEMPORIZADOR.
                                                                    4 PARA SALIR");












            /////////////////










            //Animacion de la seleccion, creamos una funcion llamada ESCRIBIR que esta incluye la animacion como si fuera
            // una maquina de escribir.

            static void ESCRIBIR(int velocidadtexto, string textanim)
            {


                for (int i = 0; i < textanim.Length; i++)
                {
                    Console.Write(textanim[i]);
                    Thread.Sleep(velocidadtexto);

                }

            }
            //AQUI CERRAMOS LA FUNCION YA QUE LA UTILIZAREMOS EN EL PROGRAMA PERO NO NECESITAMOS TENER LA LLAVES AL FINAL.


            //ABRIMOS NUESTRO MENU CON UN INT PARA PODER INTRODUCIR EL NUMERO DE OPCION A DONDE QUEREMOS IR
            int menupepe = int.Parse(Console.ReadLine());
            switch (menupepe)
            {
                case 1:
                    Console.Clear();

                    //Con este Foreach se llama todo lo que esta dentro del Array Estudiantes y con el Writeline,
                    //imprimirlo.
                    foreach (string item in estudiantes)
                    {

                        Console.WriteLine(item);
                    }

                    //MIENTRAS MAS MILISEGUNDOS TIENE LA FUNCION MAS LENTO IRA LA ANIMACION DEL TEXTO, MIENTRAS MENOS TENGA SERA MAS RAPIDO

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    ESCRIBIR(20, "Presione una tecla para continuar:");
                    Console.ReadKey();
                    Console.Clear();

                    break;

                case 2:


                    //Creamos un booleano para nuestro bucle llamado "Tiradas" ese nombre en referencia a las ruletas
                    // de los casinos.
                    Console.Clear();
                    bool tiradas = true;

                    while (tiradas)
                    {
                        //Declaramos una variable con la Clase "RANDOM" Para asi poder tener numeros aleatorios en los resultados
                        // deseados.
                        Random random = new Random();
                        //Aqui se esta diciendo que las variables estudiante1 y estudiante2 sera cualquier posicion del array estudiantes desde el 0
                        //al maximo, eso significa el .Legth
                        estudiante1 = random.Next(0, estudiantes.Length);
                        estudiante2 = random.Next(0, estudiantes.Length);
                        Console.ForegroundColor = ConsoleColor.Green;
                        // Estos \n son saltos de lineas que se necesitan para dar espacio con la funcion que da la animacion.
                        ESCRIBIR(25, "\nLe toca programar a " + estudiantes[estudiante1]);
                        Console.ForegroundColor = ConsoleColor.Red;
                        ESCRIBIR(25, "\nLe dira el programa " + estudiantes[estudiante2]);
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        //1. Ponemos un cartel que dice "VACIO" en el asiento del estudiante1 en la sala estudiantesParticipo 
                        //2.Confirmamos que el asiento está VACIO
                        //3.Movemos en el asiento VACIO de la sala estudianteParticipo, a estudiante1 de la sala estudiantes
                        // 4.Confirmamos que el asiento ya no está VACIO, es ocupado por estudiante1




                        //Declaramos que dentro de EstudianteParticipo (Nuestra Array vacia) Estudiante1 es igual a vacio.
                        estudianteParticipo[estudiante1] = "";
                        //Con esta linea, confirmamos que este puesto en la array ha pasado a ser vacio
                        Console.WriteLine(@$"{estudianteParticipo[estudiante1]}");

                        //Aqui se realiza el movimiento de la posicion random dentro del array estudiante
                        //que nos dio nuestra clase Random en la variable Estudiante1

                        estudianteParticipo[estudiante1] = estudiantes[estudiante1];

                        //Aqui por el orden del codigo estamos diciendo que el numero guardado en la variable estudiante1
                        //que ya se copio en el array estudianteparticipo se vuelve nulo, asi este es "eliminado de la lista"
                        //Recordad que arriba se coloco que estudianteparticipo + la variable estudiante es igual a nulo, entonces
                        //al asignar el valor de estudianteparticipo a estudiantes (Osea nuestro array lleno) estos nombres
                        //son reemplazados por vacio mientras se ejecuta el programa.
                        estudiantes[estudiante1] = "";


                        Console.ReadKey();
                        Console.Clear();

                        //Aqui estamos diciendo que mientras estudiante1 sea diferente a estudiante2, se ejecute toda esta linea de codigo.
                        if (estudiante1 != estudiante2)
                        {
                            Console.WriteLine("OTRA TIRADA? RESPONDE SI PARA TIRAR OTRA - NO PARA SALIR y LISTA PARA ENSEÑAR LA LISTA DE PARTICIPANTES QUE HAY.");

                            //Declaramos este string como Console.Readline porque en el diremos las opciones de nuestro "menu"
                            //de la competencia
                            string SIYNORANDOM = Console.ReadLine();
                            // Despues de la primera tirada el programa nos dara las 3 OPCIONES de arriba, Si decimos si
                            //el programa se ejecutara otra vez.
                            if (SIYNORANDOM == "SI")

                            {

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Haciendo otra tirada");

                            }
                            // Si decimos no, el bucle se vuelve negativo sacandonos del programa
                            else if (SIYNORANDOM == "NO")
                            {

                                Console.WriteLine("Ok! Ahora a programar!");
                                tiradas = false;
                                Console.ReadKey();
                                Console.Clear();

                            }
                            //Aqui una opcion de lista para mostrar a los que se eliminan y a los que no.
                            else if (SIYNORANDOM == "LISTA")
                            {
                                Console.Clear();
                                //recordar que el foreach es una herramienta que se utiliza para recuperar datos especificos
                            }     //de un array, aqui se esta diciendo que todo lo que sea "string" se muestre.
                            foreach (string item in estudiantes)
                            {

                                Console.WriteLine(item);
                            }
                        }


                    }
                    Console.Clear();

                    break;



                //Aqui empieza nuestro temporizador, es basicamente un codigo que ya vimos reutilizado varias veces.

                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($@"OPCIONES DEL TEMPORIZADOR DE LA COMPETENCIA: 
                    1. INGRESAR LOS SEGUNDOS POR UNO MISMO
                    2. 1 MINUTO
                    3. 5 MINUTOS
                    4. 10 MINUTOS        
                    5. PARA SALIR DEL TEMPORIZADOR");

                    //AQUI ABRO UN SWITCH DENTRO DE UN SWITCH PARA PODER TENER UN MENU DEL TEMPORIZADOR Y DAR
                    //DISTINTAS OPCIONES AL USUARIO
                    float menutemp = float.Parse(Console.ReadLine());




                    switch (menutemp)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("INGRESE LOS MINUTOS EN SEGUNDOS (OJO 60 SEGUNDOS SON 1 MINUTO)");

                            float numtemp = float.Parse(Console.ReadLine());
                            //AQUI PONGO QUE MIENTRAS LA VARIABLE QUE INSERTEMOS SEA MAYOR A 0 CORRERA EN UNA SECUENCIA DESCENDENTE, OSEA
                            // SE IRA RESTANDO ESTO GRACIAS QUE TIENE EL -- EN LA VARIABLE
                            while (numtemp > 0)
                            {

                                Console.WriteLine(numtemp);
                                numtemp--;
                                //ESE 1000 ES PORQUE 1000MILISEGUNDOS SON 1 SEGUNDO Y COMO ESTA EN SEGUNDOS ES IMPORTANTE
                                //QUE HAGA EL PROCESO CADA 1000 MILISEGUNDOS
                                Thread.Sleep(1000);
                                Console.Clear();

                            }
                            Console.ForegroundColor = ConsoleColor.White;

                            if (numtemp == 0)
                            {
                                //Aqui le hice un if y un else para preguntar si el objetivo del programa se cumplio
                                //Y le puse unos dibujitos para decorar el programa.
                                Console.WriteLine("El tiempo ha terminado, ¿Se cumplio el objetivo? SI/NO");
                                string SIYNO1 = Console.ReadLine();
                                if (SIYNO1 == "SI")
                                {
                                    Console.Clear();
                                    Console.WriteLine("PERFECTO, FELICIDADES BIEN HECHO!");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($@"{CARITAFELIZMENU}");
                                    Console.WriteLine($@"{CORAZONFELIZTEMP}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    ESCRIBIR(25, "PRESIONE CUALQUIER TECLA PARA CONTINUAR");


                                    //todo esto es el codigo del sonido, load para cargarlo desde su ubicacion y play
                                    //para reproducirlo, como no tiene el Looping, no se reproducira en loop.
                                    if (OperatingSystem.IsWindows())
                                    {
                                      
                                    }
                                }
                                else if (SIYNO1 == "NO")
                                {
                                    Console.Clear();
                                    Console.WriteLine("¡QUE TRISTE! SUERTE PARA LA PROXIMA");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($@"{CARITATRISTETEMP}");
                                    Console.WriteLine($@"{CORAZONTRISTEMENU}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    ESCRIBIR(25, "PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                                    if (OperatingSystem.IsWindows())
                                    {
                                    
                                    }
                                }
                            }



                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 2:
                            int numtemp1minut = 60;
                            while (numtemp1minut > 0)
                            {
                                Console.WriteLine(numtemp1minut);
                                numtemp1minut--;
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            if (numtemp1minut == 0)
                            {
                                Console.WriteLine("El tiempo ha terminado, ¿Se cumplio el objetivo? SI/NO");
                                string SIYNO1 = Console.ReadLine();
                                if (SIYNO1 == "SI")
                                {
                                    Console.Clear();
                                    Console.WriteLine("PERFECTO, FELICIDADES BIEN HECHO!");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($@"{CARITAFELIZMENU}");
                                    Console.WriteLine($@"{CORAZONFELIZTEMP}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    ESCRIBIR(25, "PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                                    if (OperatingSystem.IsWindows())
                                    {
                                    
                                    }
                                }
                                else if (SIYNO1 == "NO")
                                {
                                    Console.Clear();
                                    Console.WriteLine("¡QUE TRISTE! SUERTE PARA LA PROXIMA");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($@"{CARITATRISTETEMP}");
                                    Console.WriteLine($@"{CORAZONTRISTEMENU}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    ESCRIBIR(25, "PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                                    if (OperatingSystem.IsWindows())
                                    {
                                     
                                    }
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 3:
                            int numtemp5minut = 300;
                            while (numtemp5minut > 0)
                            {
                                Console.WriteLine(numtemp5minut);
                                numtemp5minut--;
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            if (numtemp5minut == 0)
                            {
                                Console.WriteLine("El tiempo ha terminado, ¿Se cumplio el objetivo? SI/NO");
                                string SIYNO1 = Console.ReadLine();
                                if (SIYNO1 == "SI")
                                {
                                    Console.Clear();
                                    Console.WriteLine("PERFECTO, FELICIDADES BIEN HECHO!");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($@"{CARITAFELIZMENU}");
                                    Console.WriteLine($@"{CORAZONFELIZTEMP}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    ESCRIBIR(25, "PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                                    if (OperatingSystem.IsWindows())
                                    {
                                      
                                    }
                                }
                                else if (SIYNO1 == "NO")
                                {
                                    Console.Clear();
                                    Console.WriteLine("¡QUE TRISTE! SUERTE PARA LA PROXIMA");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($@"{CARITATRISTETEMP}");
                                    Console.WriteLine($@"{CORAZONTRISTEMENU}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    ESCRIBIR(25, "PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                                    if (OperatingSystem.IsWindows())
                                    {
                                      
                                    }
                                }
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;


                        case 4:
                            int numtemp10minut = 600;
                            while (numtemp10minut > 0)
                            {
                                Console.WriteLine(numtemp10minut);
                                numtemp10minut--;
                                Thread.Sleep(1000);
                                Console.Clear();

                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            if (numtemp10minut == 0)
                            {
                                Console.WriteLine("El tiempo ha terminado, ¿Se cumplio el objetivo? SI/NO");
                                string SIYNO1 = Console.ReadLine();
                                if (SIYNO1 == "SI")
                                {
                                    Console.Clear();
                                    Console.WriteLine("PERFECTO, FELICIDADES BIEN HECHO!");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($@"{CARITAFELIZMENU}");
                                    Console.WriteLine($@"{CORAZONFELIZTEMP}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    ESCRIBIR(25, "PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                                    if (OperatingSystem.IsWindows())
                                    {
                                     
                                    }
                                }
                                else if (SIYNO1 == "NO")
                                {
                                    Console.Clear();
                                    Console.WriteLine("¡QUE TRISTE! SUERTE PARA LA PROXIMA");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($@"{CARITATRISTETEMP}");
                                    Console.WriteLine($@"{CORAZONTRISTEMENU}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    ESCRIBIR(25, "PRESIONE CUALQUIER TECLA PARA CONTINUAR");
                                    if (OperatingSystem.IsWindows())
                                    {
                                   
                                    }
                                }
                            }
                            break;
                        //Todo eso se puede simplificar con una funcion pero las "aprendi" a usar cuando hice
                        //lo de la animacion 

                        //esto para volver al menu principal del programa.
                        case 5:
                            Console.WriteLine("¡DE VUELTA AL MENU!");
                            ESCRIBIR(5, "PRESIONA CUALQUIER TECLA PARA CONTINUAR");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        //Y esto por si alguien pone algun numero que no esta en el menu.
                        default:

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("¡ESO NO ES UNA OPCION! PRESIONA UNA TECLA PARA VOLVER.");
                            Console.ReadKey();
                            Console.Clear();
                            break;



                    }   //ESTA ULTIMA LLAVE ES IMPORTANTE YA QUE ES LA QUE NOS CIERRA EL SWITCH DEL MENU DE TEMPORIZADOR
                        //ASI NO SE COMBINAN LOS SWITCHES ENTRE SI Y EVITAMOS ERRORES
                    break;







                //SALIDA DEL MENU DEL PROGRAMA DE LA COMPETENCIA



                case 4:
                    Console.WriteLine("¡ADIOS! PRESIONE CUALQUIER TECLA PARA SALIR.");
                    bucle = false;
                    Console.ReadKey();
                    Console.Clear();
                    break;


                //POR SI PONEN UNA OPCION QUE NO ES.
                default:
                    Console.WriteLine("¡ERROR! ESO NO ES UNA OPCION PRESIONA UNA TECLA PARA CONTINUAR");
                    Console.ReadKey();
                    Console.Clear();

                    break;










            }
            //LLAVE DEL WHILE PRINCIPAL       
        }
    }
    //LLAVE DEL CLASS PROGRAM (NO TOCAR)
}


























//██████╗  █████╗ ███╗   ██╗██╗███████╗██╗         ██╗  ██╗███████╗██████╗ ███╗   ██╗ █████╗ ███╗   ██╗██████╗ ███████╗███████╗    ██████╗  ██████╗ ██████╗ ██████╗        ██╗██████╗  ██╗ █████╗ 
//██╔══██╗██╔══██╗████╗  ██║██║██╔════╝██║         ██║  ██║██╔════╝██╔══██╗████╗  ██║██╔══██╗████╗  ██║██╔══██╗██╔════╝╚══███╔╝    ╚════██╗██╔═████╗╚════██╗╚════██╗      ███║╚════██╗███║██╔══██╗
//██║  ██║███████║██╔██╗ ██║██║█████╗  ██║         ███████║█████╗  ██████╔╝██╔██╗ ██║███████║██╔██╗ ██║██║  ██║█████╗    ███╔╝      █████╔╝██║██╔██║ █████╔╝ █████╔╝█████╗╚██║ █████╔╝╚██║╚██████║
//██║  ██║██╔══██║██║╚██╗██║██║██╔══╝  ██║         ██╔══██║██╔══╝  ██╔══██╗██║╚██╗██║██╔══██║██║╚██╗██║██║  ██║██╔══╝   ███╔╝      ██╔═══╝ ████╔╝██║██╔═══╝ ██╔═══╝ ╚════╝ ██║ ╚═══██╗ ██║ ╚═══██║
//██████╔╝██║  ██║██║ ╚████║██║███████╗███████╗    ██║  ██║███████╗██║  ██║██║ ╚████║██║  ██║██║ ╚████║██████╔╝███████╗███████╗    ███████╗╚██████╔╝███████╗███████╗       ██║██████╔╝ ██║ █████╔╝





//IIIIIIIIIITTTTTTTTTTTTTTTTTTTTTTTLLLLLLLLLLL                            AAA               
//I::::::::IT:::::::::::::::::::::TL:::::::::L                           A:::A              
//I::::::::IT:::::::::::::::::::::TL:::::::::L                          A:::::A             
//II::::::IIT:::::TT:::::::TT:::::TLL:::::::LL                         A:::::::A            
//I::::I  TTTTTT  T:::::T  TTTTTT  L:::::L                          A:::::::::A           
//I::::I          T:::::T          L:::::L                         A:::::A:::::A          
//I::::I          T:::::T          L:::::L                        A:::::A A:::::A         
//I::::I          T:::::T          L:::::L                       A:::::A   A:::::A        
//I::::I          T:::::T          L:::::L                      A:::::A     A:::::A       
//I::::I          T:::::T          L:::::L                     A:::::AAAAAAAAA:::::A      
//I::::I          T:::::T          L:::::L                    A:::::::::::::::::::::A     
//I::::I          T:::::T          L:::::L         LLLLLL    A:::::AAAAAAAAAAAAA:::::A    
//II::::::II      TT:::::::TT      LL:::::::LLLLLLLLL:::::L   A:::::A             A:::::A   
//I::::::::I      T:::::::::T      L::::::::::::::::::::::L  A:::::A               A:::::A  
//I::::::::I      T:::::::::T      L::::::::::::::::::::::L A:::::A                 A:::::A 
//IIIIIIIIII      TTTTTTTTTTT      LLLLLLLLLLLLLLLLLLLLLLLLAAAAAAA                   AAAAAAA







//_______oBBBBB8o______oBBBBBBB
//_____o8BBBBBBBBBBB__BBBBBBBBB8________o88o,
//___o8BBBBBB**8BBBB__BBBBBBBBBB_____oBBBBBBBo,
//__oBBBBBBB*___***___BBBBBBBBBB_____BBBBBBBBBBo,
//_8BBBBBBBBBBooooo___*BBBBBBB8______*BB*_8BBBBBBo,
//_8BBBBBBBBBBBBBBBB8ooBBBBBBB8___________8BBBBBBB8,
//__*BBBBBBBBBBBBBBBBBBBBBBBBBB8_o88BB88BBBBBBBBBBBB,
//____*BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB8,
//______**8BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB*,
//___________*BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB8*,
//____________*BBBBBBBBBBBBBBBBBBBBBBBB8888**,
//_____________BBBBBBBBBBBBBBBBBBBBBBB*,
//_____________*BBBBBBBBBBBBBBBBBBBBB*,
//_____________*BBBBBBBBBBBBBBBBBB8,
//_______________*BBBBBBBBBBBBBBBB*,
//________________8BBBBBBBBBBBBBBB8,
//_________________8BBBBBBBBBBBBBBBo,
//__________________BBBBBBBBBBBBBBB8,
//__________________BBBBBBBBBBBBBBBB,
//__________________8BBBBBBBBBBBBBBB8,
//__________________*BBBBBBBBBBBBBBBB,
//__________________8BBBBBBBBBBBBBBBB8,
//_________________oBBBBBBBBBBBBBBBBBB,
//________________oBBBBBBBBBBBBBBBBBBB,
//________________BBBBBBBBBBBBBBBBBBBB,
//_______________8BBBBBBBBBBBBBBBBBBB8,
//______________oBBBBBBBBB88BBBBBBBBB8,
//______________8BBBBBBBBB*8BBBBBBBBB*,
//______________BBBBBBBBB*_BBBBBBBBB8,
//______________BBBBBBBB8_oBBBBBBBBB*,
//______________8BBBBBBB__oBBBBBBBB*,
//______________BBBBBBB*__8BBBBBBB*,
//_____________8BBBBBB*___BBBBBBB*,
//____________8BBBBBB8___oBBBBBB8,
//__________8BBBBBB8____8BBBBBB*,
//__________oBBBBBB8____BBBBBBB8,
//__________BBBBBBB8___BBBBBBBB*,
//________oBBBBBBB8___BBBBBBBB,
//_________8BBBBBB8____BBBBBBB*,
//_________BBBBBB*_____8BBBBB*,
//_______oBBBB8_______BBBBB*,
//________oBBB8________BBBB*,
//______8BBBB*_______*BBBBBBBB8o,
//______BBBBB*____________*88BBBo
