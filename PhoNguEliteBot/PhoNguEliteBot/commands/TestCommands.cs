using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace PhoNguEliteBot.commands
{
    public class TestCommands : BaseCommandModule
    {
        [Command("Test")]
        public async Task MyFirstCommand(CommandContext context)
        {
            await context.Channel.SendMessageAsync($"Địt mẹ mày {context.User.Username}");
        }

        [Command("Trà")]
        public async Task MySecondCommand(CommandContext context)
        {
            await context.Channel.SendMessageAsync("Nga");
        }

        [Command("vha")]
        public async Task EmbedMessage(CommandContext context)
        {
            var msg = new DiscordMessageBuilder().
                AddEmbed(new DiscordEmbedBuilder().
                WithTitle("Ánh Đần").
                WithImageUrl("https://scontent.fhan17-1.fna.fbcdn.net/v/t39.30808-6/364806944_2357645927758475_4470006491723217279_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=aa7b47&_nc_eui2=AeEJjU0zfxbvDTrTMPoPQqPKrF52iqpy_yesXnaKqnL_J3KjFD6hCNixi83tOrf-y96S5Vt3gZCUuScjBXnbVnBt&_nc_ohc=RChcEYF_J_8Q7kNvgFK6Zpi&_nc_ht=scontent.fhan17-1.fna&oh=00_AYDLFAtnxV9WWqAtWL7Cs4TWT7knaHO8HhlaOB0mN_U6PQ&oe=66C3D11E").
                WithColor(DiscordColor.Red));
            await context.Channel.SendMessageAsync(msg);
        }

        [Command("dat")]
        public async Task EmbedMessage2(CommandContext context)
        {
            var msg = new DiscordMessageBuilder().
                AddEmbed(new DiscordEmbedBuilder().
                WithImageUrl("https://scontent.fhan17-1.fna.fbcdn.net/v/t39.30808-6/324906114_3468409300045135_5851207402117046091_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=aa7b47&_nc_eui2=AeF9TzSR-VRSmMiIbc_gqbhiSNEJtD3-lutI0Qm0Pf6W66NHZV2DJcE5H2i6jFqt7kZEGFv-5rZ4d9-RoR4HO4qX&_nc_ohc=4sbPssXO3-sQ7kNvgFJ5SW4&_nc_ht=scontent.fhan17-1.fna&oh=00_AYAxIGYNYy0joZtzNM9zbra2mt6mjmpwGZHE1kPth6xEaQ&oe=66C3B4C0").
                WithColor(DiscordColor.Red));
            await context.Channel.SendMessageAsync(msg);
        }
    }
}
