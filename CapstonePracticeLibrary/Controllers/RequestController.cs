using CapstonePracticeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapstonePracticeLibrary.Controllers
    {
    public class RequestController
        {
        public const string StatusNew = "NEW";
        public const string StatusEdit = "EDIT";
        public const string StatusReview = "REVIEW";
        public const string StatusApproved = "APPROVED";
        public const string StatusRejected = "REJECTED";

        private readonly AppDbContext context = new AppDbContext();

        public IEnumerable<Request> GetRequestsToReviewNotOwn(int userid)
            {
            return context.Requests
                   .Where(x => x.UserId != userid && x.Status == StatusReview)
                   .ToList();

            }
        }
    }

    //    public bool SetToReview(Request request)
    //        {
    //        if (request.Total <= 50)
    //            {
    //            request.Status = StatusApproved;
    //            } else
    //            {
    //            request.Status = StatusReview;
    //            }
    //        return Update(request.Id, request);
    //        }
    //    public bool SetToApproved()
    //    }
    //}
