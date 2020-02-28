using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapstonePracticeLibrary.Controllers
    {
    public class RequestLineController
        {
        private readonly AppDbContext context = new AppDbContext();

        private void RecalcRequestTotal(int requestId)
            {
            var request = context.Requests.Find(requestId);
            request.Total = request.RequestLines.Sum(x => x.Quantity * x.Product.Price);
            context.SaveChanges();
            Console.WriteLine($"Sum is {request}");
            }
        }
    }
