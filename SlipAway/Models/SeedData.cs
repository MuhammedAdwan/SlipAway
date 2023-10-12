using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SlipAway.Data;
using System;
using System.Linq;

namespace SlipAway.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SlipAwayContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SlipAwayContext>>()))
            {

                //lets look for products
                if(context.Product.Any())
                {
                    //to seed the DB
                    return;
                }

               //to add new products to the db
               context.Product.AddRange(
                    new Product
                    {
                        Name = "Cozy Classic",
                        Description = "Our Classic cozy Slippers",
                        Price = 24.99M,
                        Category = "Classic",
                        ImageUrl = "/Img/home2.jpg",
                        CustomerReview = 4.7
                    },
                   
                    new Product
                    {
                        Name = "Fluffy Dreams",
                        Description = "experince the comfort of the cloud",
                        Price = 29.99M,
                        Category = "Fluffy",
                        ImageUrl = "/Img/home1.jpg",
                        CustomerReview = 4.9
                    },

                    new Product
                    {
                        Name = "Beach",
                        Description = "Feel the Sand",
                        Price = 9.99M,
                        Category = "Beach",
                        ImageUrl = "/Img/beach1.jpg",
                        CustomerReview = 4.9
                    },

                    new Product
                    {
                        Name = "Beach",
                        Description = "Feel the Sand",
                        Price = 9.99M,
                        Category = "Beach",
                        ImageUrl = "/Img/beach2.jpg",
                        CustomerReview = 4.8
                    },
                    new Product
                    {
                        Name = "Kids",
                        Description = "For our little Feet",
                        Price = 7.99M,
                        Category = "Kids",
                        ImageUrl = "/Img/home1.jpg",
                        CustomerReview = 4.5
                    },

                    new Product
                    {
                        Name = "Tiny fluff",
                        Description = "keep the little feet warm at home too",
                        Price = 9.99M,
                        Category = "Kids",
                        ImageUrl = "/Img/home2.jpg",
                        CustomerReview = 4.7
                    },
                    new Product
                    {
                        Name = "Casual Comfort",
                        Description = "Everyday Comfort for your daily adventures",
                        Price = 29.99M,
                        Category = "Casual",
                        ImageUrl = "/Img/outdoors1.jpg",
                        CustomerReview = 4.6
                    },

                    new Product
                    {
                        Name = "Cozy Classic",
                        Description = "Our Classic cozy Slippers",
                        Price = 24.99M,
                        Category = "Classic",
                        ImageUrl = "/Img/home2.jpg",
                        CustomerReview = 4.7
                    },

                    new Product
                    {
                        Name = "Cozy Classic",
                        Description = "Our Classic cozy Slippers",
                        Price = 24.99M,
                        Category = "Classic",
                        ImageUrl = "/Img/home2.jpg",
                        CustomerReview = 4.7
                    },
                    new Product
                    {
                        Name = "Cozy Classic",
                        Description = "Our Classic cozy Slippers",
                        Price = 24.99M,
                        Category = "Classic",
                        ImageUrl = "/Img/home2.jpg",
                        CustomerReview = 4.7
                    },

                    new Product
                    {
                        Name = "Cozy Classic",
                        Description = "Our Classic cozy Slippers",
                        Price = 24.99M,
                        Category = "Classic",
                        ImageUrl = "/Img/home2.jpg",
                        CustomerReview = 4.7
                    }

                    })