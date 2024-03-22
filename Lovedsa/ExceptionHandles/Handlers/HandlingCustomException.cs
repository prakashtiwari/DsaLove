using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandles.Handlers
{
    public class HandlingCustomException
    {
        
            public void GetYouTubeVideo()
            {
                try
                {
                    throw new Exception("OOPS: Problem while loading video");

                }
                catch (Exception ex)
                {
                    throw new CustomException("Problem while downloading", ex);
                }
            }


        
    }
}


