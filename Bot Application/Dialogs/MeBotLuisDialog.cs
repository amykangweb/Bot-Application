using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.Luis;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Luis.Models;
using System.Threading;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.FormFlow;
using System.Text;
using System.Configuration;

namespace Bot_Application
{
    [LuisModel("5f6fa859-da8d-4116-bf14-e6d1cf1187cb", "32c357ba35604932b60f72c6a05e4fb0")]
    [Serializable]
    public class MeBotLuisDialog : LuisDialog<object>
    {
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("I'm sorry. I didn't understand you.");
            context.Wait(MessageReceived);
        }

        [LuisIntent("AboutMe")]
        public async Task AboutMe(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"Ankit is a Software Engineer currently working in Microsoft Center of Excellence team at Mindtree.");
            await context.PostAsync(@"He is a technology enthusiast and loves to dig in emerging technologies.");
            context.Wait(MessageReceived);
        }
    }
}