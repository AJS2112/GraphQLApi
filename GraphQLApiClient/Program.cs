namespace GraphQLApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Welcome to the GraphQL Client Demo!");




            Console.WriteLine("Click Enter to run the query ...");
            Console.ReadLine();
            await GraphQLCourseClient.GetCoursesViaHttpGet();



            Console.Read();
        }

    }
}