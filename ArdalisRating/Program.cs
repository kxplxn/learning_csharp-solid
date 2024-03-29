﻿using System;

namespace ArdalisRating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ardalis Insurance Rating System Starting...");
            var logger = new FileLogger();

            var engine = new RatingEngine(logger,
                new FilePolicySource(),
                new JsonPolicySerializer(),
                new RaterFactory(logger));
            engine.Rate();

            Console.WriteLine(engine.Rating > 0 ? $"Rating: {engine.Rating}" : "No rating produced.");
        }
    }
}
