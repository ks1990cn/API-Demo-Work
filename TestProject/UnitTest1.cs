using Moq;
using ProjectAPI.Controllers;
using ProjectAPI.DataLayer;
using ProjectAPI.Repositories;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject
{
    public class UnitTest : TestExtentions
    {
        private QuotesDbContext context;
        public UnitTest():base()
        {
            context  = new QuotesDbContext(dbOption);
        }
        /// <summary>
        /// Final Result
        /// </summary>
        /// <returns></returns>
        public static List<Tuple<string,int>> list_data()
        {
            List<Tuple<string, int>> tuples = new List<Tuple<string, int>>();
            tuples.Add(Tuple.Create("hi",1));
            return tuples;
        }
        
    }
}
