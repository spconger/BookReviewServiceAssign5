using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BRService" in code, svc and config file together.
public class BRService : IBRService
{
    BookReviewDbEntities bre = new BookReviewDbEntities();
    public int BookReviewLogin(string user, string password)
    {
        int key = 0;
        int result = bre.usp_ReviewerLogin(user, password);
        if(result != -1)
        {
            var ky = (from r in bre.Reviewers
                      where r.ReviewerUserName.Equals(user)
                      select r.ReviewerKey).FirstOrDefault();
            key = (int)ky;
           }

        return key;
    }

    public List<Book> GetBooks()
    {
        throw new NotImplementedException();
    }

    public List<Review> GetReviews(int reviewerKey)
    {
        throw new NotImplementedException();
    }

    public bool NewReview(Review rev)
    {
        throw new NotImplementedException();
    }

    public bool RegisterReviewer(ReviewerLite r)
    {
        throw new NotImplementedException();
    }
}
