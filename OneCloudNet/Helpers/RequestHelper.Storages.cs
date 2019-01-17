namespace OneCloudNet.Helpers
{
    using RestSharp;

    internal partial class RequestHelper
    {
        internal IRestRequest CreateGetStorageRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/storage";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        internal IRestRequest CreateActivateStorageRequest()
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/storage";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        internal IRestRequest CreateDeactivateStorageRequest()
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/storage";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        internal IRestRequest CreateGetStorageUsersRequest()
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/storage/users";
            request.AddHeader("Authorization", "Bearer " + _token);

            return request;
        }

        internal IRestRequest CreateCreateStorageUserRequest(int userName, bool persistPassword)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/storage/users";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("UserName", userName);
            request.AddParameter("PersistPassword", persistPassword);

            return request;
        }

        internal IRestRequest CreateGetStorageUserRequest(int userID)
        {
            var request = new RestRequest(Method.GET);
            request.Resource = "/storage/users/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", userID, ParameterType.UrlSegment);

            return request;
        }

        internal IRestRequest CreateChangeStorageUserPasswordRequest(int userID, bool persistPassword)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/storage/users/{id}/change-password";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", userID, ParameterType.UrlSegment);
            request.AddParameter("PersistPassword", persistPassword);

            return request;
        }

        internal IRestRequest CreateDeleteStorageUserRequest(int userID)
        {
            var request = new RestRequest(Method.DELETE);
            request.Resource = "/storage/users/{id}";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", userID, ParameterType.UrlSegment);

            return request;
        }

        internal IRestRequest CreateBlockStorageUserRequest(int userID)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/storage/users/{id}/block";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", userID, ParameterType.UrlSegment);

            return request;
        }

        internal IRestRequest CreateUnblockStorageUserRequest(int userID)
        {
            var request = new RestRequest(Method.POST);
            request.Resource = "/storage/users/{id}/unblock";
            request.AddHeader("Authorization", "Bearer " + _token);
            request.AddParameter("id", userID, ParameterType.UrlSegment);

            return request;
        }
    }
}
