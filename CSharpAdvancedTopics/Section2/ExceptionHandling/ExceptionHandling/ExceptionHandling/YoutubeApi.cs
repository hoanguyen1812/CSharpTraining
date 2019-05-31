using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Assess webservice
                // Read the data
                // Get the the list of videos
                throw new Exception("Exception new");
            }
            catch (Exception e)
            {
                // Log
                throw new YoutubeException("Could not fetch the video from Youtube", e);
            }
            return new List<Video>();
        }
    }
}