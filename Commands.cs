using Discord.Commands;
using Discord;
using System.Threading.Tasks;
using System;

namespace BotCari.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("manonlife")]
        public async Task lol()
        {
            await Context.Channel.SendMessageAsync("Fuck you cunt");
        }

        [Command("refgard")]
        public async Task big()
        {
            await Context.Channel.SendMessageAsync("Refgard? LOL!");
        }

        [Command("invite")]
        public async Task ok()
        {
            await Context.Channel.SendMessageAsync("Invite me to your server! http://bit.ly/2xnXFXP");
        }

        [Command("dev")]
        public async Task dev()
        {
            await Context.Channel.SendMessageAsync("Join my dev's server! https://discord.gg/xV9bgBA");
        }

        [Command("keemstar")]
        public async Task keem()
        {
            await Context.Channel.SendMessageAsync("https://twitter.com/KEEMSTAR/status/910584916039098373");
        }

        [Command("techsupport")]
        public async Task curry()
        {
            await Context.Channel.SendMessageAsync("Hello this tech support, how can help you today? Show vegana");
        }

        [Command("Carson")]
        public async Task carson()
        {
            await Context.Channel.SendMessageAsync("Fuck you Carson");
        }

        [Command("hello")]
        public async Task uh()
        {
            await Context.Channel.SendMessageAsync("Hi! How are you?");
        }

        [Command("support")]
        public async Task support()
        {
            await Context.Channel.SendMessageAsync("Support my dev: https://www.patreon.com/manon");
        }

        [Command("help")]
        public async Task help()
        {
            await Context.Channel.SendMessageAsync("**invite** - invite me to your server | **dev** - invite link to my dev's server | **support** - link to support my dev | **8ball** - ask anything! | **dicksize** - tells the size of your dick. | **gay** - shows a percentage of how gay you are!| ***Commands in progress:*** *Google search, r34 search* | ***Commands updated frequently***");
        }

        [Command("8ball")]
        public async Task EightBall([Remainder] string input)
        {
            int randomIndex = rand.Next(predictionsTexts.Length);
            string text = predictionsTexts[randomIndex];
            await ReplyAsync(":8ball: | " + Context.User.Mention + ", " + text);
        }

        Random rand = new Random();

        string[] predictionsTexts = new string[]
            {
                "probably not lol",
                "I don't think so lmao",
                "yeah",
                "I don't know",
                "no lol",
                "hell yeah",
                "no fuck off",
                "definitely",
                "100%",
            };

        [Command("dicksize")]
        public async Task dicksize([Remainder] string input)
        {
            int randomIndex = rand.Next(funnyTexts.Length);
            string text = funnyTexts[randomIndex];
            await ReplyAsync(":eggplant: | That dick is " + text);
        }

        string[] funnyTexts = new string[]
            {
                "like 12 feet",
                "2 inches lmao",
                "fucking massive",
                "nonexistant",
                "a micropenis",
                "8 inches",
                "a 3 incher pincher",
                "a 4 millimeter peter",
            };

        [Command("gay")]
        public async Task gay([Remainder] string input)
        {
            int randomIndex = rand.Next(gayTexts.Length);
            string text = gayTexts[randomIndex];
            await ReplyAsync(":gay_pride_flag: | **" + text + "** gay");
        }

        string[] gayTexts = new string[]
            {
                "1%",
                "2%",
                "3%",
                "4%",
                "5%",
                "6%",
                "7%",
                "8%",
                "9%",
                "10%",
                "11%",
                "12%",
                "13%",
                "14%",
                "15%",
                "16%",
                "17%",
                "18%",
                "19%",
                "20%",
                "21%",
                "22%",
                "23%",
                "24%",
                "25%",
                "26%",
                "27%",
                "28%",
                "29%",
                "30%",
                "31%",
                "32%",
                "33%",
                "34%",
                "35%",
                "36%",
                "37%",
                "38%",
                "39%",
                "40%",
                "41%",
                "42%",
                "43%",
                "44%",
                "45%",
                "46%",
                "47%",
                "48%",
                "49%",
                "50%",
                "51%",
                "52%",
                "53%",
                "54%",
                "55%",
                "56%",
                "57%",
                "58%",
                "59%",
                "60%",
                "61%",
                "62%",
                "63%",
                "64%",
                "65%",
                "66%",
                "67%",
                "68%",
                "69%",
                "70%",
                "71%",
                "72%",
                "73%",
                "74%",
                "75%",
                "76%",
                "77%",
                "78%",
                "79%",
                "80%",
                "81%",
                "82%",
                "83%",
                "84%",
                "85%",
                "86%",
                "87%",
                "88%",
                "89%",
                "90%",
                "91%",
                "92%",
                "93%",
                "94%",
                "95%",
                "96%",
                "97%",
                "98%",
                "99%",
                "100%",




            };

    }
}
