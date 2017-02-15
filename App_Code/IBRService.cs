using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBRService" in both code and config file together.
[ServiceContract]
public interface IBRService
{
    [OperationContract]
    int BookReviewLogin(string user, string password);

    [OperationContract]
    bool RegisterReviewer(ReviewerLite r);

    [OperationContract]
    bool NewReview(Review rev);

    [OperationContract]
    List<Review> GetReviews(int reviewerKey);

    [OperationContract]
    List<Book> GetBooks();

}
[DataContract]
public class ReviewerLite
{
    [DataMember]
    public string Lastname { set; get; }

    [DataMember]
    public string Firstname { set; get; }

    [DataMember]
    public string Email { set; get; }

    [DataMember]
    public string Username { set; get; }

    [DataMember]
    public string Password { set; get; }

}
