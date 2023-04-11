using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLApiClient
{
    public class GraphQLCourseClient
    {
        private readonly IGraphQLClient _client;

        public GraphQLCourseClient(IGraphQLClient client)
        {
            _client = client;
        }

        public static async Task GetCoursesViaHttpGet()
        {

            var graphQLClient = new GraphQLHttpClient(new Uri("http://localhost:5006/graphql/getcourses"), new NewtonsoftJsonSerializer());

            //mutiple courses
            var qString = "{ courses { title, level, instructor, ratings { studentName , review } } }";

            //single course
            //var qString = "{ course (id:1) { title, level, instructor } }";

            var response = await graphQLClient.HttpClient.GetAsync(@"http://localhost:5006/graphql/getcourses?query= " + qString);


            var result = response.Content.ReadAsStringAsync();

            //Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(result.Result);



        }








    }
}
