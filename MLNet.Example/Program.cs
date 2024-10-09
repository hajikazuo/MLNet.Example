using MLNet_Example;

namespace MLNet.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sampleDataList = new List<SentimentModel.ModelInput>
            {
                new SentimentModel.ModelInput { Col0 = "The service was outshining & I definitely recommend the Halibut." },
                new SentimentModel.ModelInput { Col0 = "The food was terrible." },
                new SentimentModel.ModelInput { Col0 = "WILL NEVER EVER GO BACK AND HAVE TOLD MANY PEOPLE WHAT HAD HAPPENED." },
                new SentimentModel.ModelInput { Col0 = "I don't recommend unless your car breaks down in front of it and you are starving." },
                new SentimentModel.ModelInput { Col0 = "I will come back here every time I'm in Vegas." },
                new SentimentModel.ModelInput { Col0 = "This place deserves one star and 90% has to do with the food." },
                new SentimentModel.ModelInput { Col0 = "This is a disgrace." },
                new SentimentModel.ModelInput { Col0 = "Def coming back to bowl next time." },
                new SentimentModel.ModelInput { Col0 = "If you want healthy authentic or ethic food, try this place." },
                new SentimentModel.ModelInput { Col0 = "I will continue to come here on ladies night andddd date night ... highly recommend this place to anyone who is in the area (;." },
                new SentimentModel.ModelInput { Col0 = "I have been here several times in the past, and the experience has always been great." },
                new SentimentModel.ModelInput { Col0 = "We walked away stuffed and happy about our first Vegas buffet experience." },
                new SentimentModel.ModelInput { Col0 = "Service was excellent and prices are pretty reasonable considering this is Vegas and located inside the Crystals shopping mall by Aria." },
                new SentimentModel.ModelInput { Col0 = "To summarize... the food was incredible, nay, transcendant... but nothing brings me joy quite like the memory of the pneumatic condiment dispenser." },
                new SentimentModel.ModelInput { Col0 = "I'm probably one of the few people to ever go to Ians and not like it." },
                new SentimentModel.ModelInput { Col0 = "Kids pizza is always a hit too with lots of great side dish options for the kiddos!" },
                new SentimentModel.ModelInput { Col0 = "Service is perfect and the family atmosphere is nice to see." },
                new SentimentModel.ModelInput { Col0 = "Cooked to perfection and the service was impeccable." },
            };


            foreach (var sampleData in sampleDataList)
            {
                var result = SentimentModel.Predict(sampleData);
                var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
                Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}\n");
            }
        }
    }
}
