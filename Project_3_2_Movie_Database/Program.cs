//
//
List<Movie> flickList = new List<Movie>();
flickList.Add(new Movie("Fantasia", "animated"));
flickList.Add(new Movie("Tangled", "animated"));
flickList.Add(new Movie("Shrek", "animated"));
flickList.Add(new Movie("Aladdin", "animated"));

flickList.Add(new Movie("A Star Is Born", "drama"));
flickList.Add(new Movie("A Streetcar Named Desire", "drama"));
flickList.Add(new Movie("Almost Famous", "drama"));
flickList.Add(new Movie("Good Will Hunting", "drama"));

flickList.Add(new Movie("Hellraiser", "horror"));
flickList.Add(new Movie("The Mist", "horror"));
flickList.Add(new Movie("The Ring", "horor"));
flickList.Add(new Movie("Evil Dead 2", "horor"));

flickList.Add(new Movie("Gattaca", "scifi"));
flickList.Add(new Movie("Edge of Tomorrow", "scifi"));
flickList.Add(new Movie("Blade Runner", "scifi"));
flickList.Add(new Movie("Aliens", "scifi"));

bool goAgain = true;
//Declare loop Var
//Begin Loop
while (goAgain)
{
    string uGenre = "";
    int uGenreNum = 0;
    bool validGenre = false;
    Console.Clear();
    Console.WriteLine("        Welcome to the Movie List Application!\n");
    Console.WriteLine(":: [1] Animated:::[2] Drama:::[3] Scifi:::[4] Horror ::");
    Console.WriteLine("::              -List Movies by Genre-               ::\n");
    while (!validGenre)
    {




        Console.Write("Please Enter a Genre:\n");
        uGenre = (Console.ReadLine().ToLower());

        if(!(int.TryParse(uGenre,out uGenreNum)))
        {
            if (uGenre.Length >= 3)
            {



                switch (uGenre.Substring(0, 3))
                {
                    case "ani":
                        validGenre = true;
                        uGenre = "animated";
                        break;
                    case "dra":
                        validGenre = true;
                        uGenre = "drama";
                        break;
                    case "sci":
                        validGenre = true;
                        uGenre = "scifi";
                        break;
                    case "hor":
                        validGenre = true;
                        uGenre = "horror";
                        break;
                    default:
                        validGenre = false;
                        Console.Clear();
                        Console.WriteLine("    INVALID GENRE!   INVALID GENRE!   INVALID GENRE! \n");
                        Console.WriteLine(":: [1] Animated:::[2] Drama:::[3] Scifi:::[4] Horror ::");
                        Console.WriteLine("::    -   PLEASE CHOOSE FROM THE GENRES LISTED! -    ::\n");

                        break;

                }
            }
        }
        else
        {
            switch (uGenreNum)
            {
                case 1:
                    validGenre = true;
                    uGenre = "animated";
                    break;
                case 2:
                    validGenre = true;
                    uGenre = "drama";
                    break;
                case 3:
                    validGenre = true;
                    uGenre = "scifi";
                    break;               
                case 4:
                    validGenre = true;
                    uGenre = "horror";
                    break;
                default:
                    validGenre = false;
                    Console.Clear();
                    Console.WriteLine("    INVALID GENRE!   INVALID GENRE!   INVALID GENRE! \n");
                    Console.WriteLine(":: [1] Animated:::[2] Drama:::[3] Scifi:::[4] Horror ::");
                    Console.WriteLine("::    -   PLEASE CHOOSE FROM THE GENRES LISTED! -    ::\n");

                    break;

            }
        }
    }

    //Display Matches

    Console.WriteLine($"Here are some {uGenre} movies:");

    foreach(Movie current in flickList )
    {

        if (current.catagory == uGenre)
        {
            Console.WriteLine(current.title);
        }

    }

    bool validAgain = false;
    while (!validAgain)
    {

        Console.WriteLine("Continue? (y/n)");
        string uResponse = ((Console.ReadLine()).ToLower()).Trim();

        if (uResponse[0] == 'y' || uResponse[0] == 'n')
        {
            validAgain = true;
            if (uResponse[0] == 'n')
            {
                goAgain = false;
            }
        }
    }

}

Console.WriteLine("Good Bye!");


//Go Again?
//End Loop











class Movie
{
    public string title;
    public string catagory;

    public Movie(string _title, string _catagory)
    {
        this.title = _title;
        this.catagory = _catagory;
    }

}

