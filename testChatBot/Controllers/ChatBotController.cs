using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using answersDataAccess;

namespace testChatBot.Controllers
{
    public class ChatBotController : ApiController
    {
        // GET: api/ChatBot
        public IEnumerable<answersTable> Get()
        {
            using (chatbotEntities entities = new chatbotEntities())
            {
                return entities.answersTables.ToList();
            }
        }

        public answersTable Get(int id)
        {
            using (chatbotEntities entities = new chatbotEntities())
            {
                return entities.answersTables.FirstOrDefault(a => a.id == id);
            }
        }
    }
}
