using Strategy_Pattern;
using Strategy_Pattern.StrategyService;

Random random = new Random();

for(int i = 0; i < 10; i++)
{
    Navigator navigatorStrategy = new Navigator();
    var randomNumber = random.Next(0, 3);

    switch (randomNumber)
    {
        case 0:
            navigatorStrategy.setNavigator(new PublicTransportStrategy());
            break;
        case 1:
            navigatorStrategy.setNavigator(new RoadStrategy());
            break;
        case 2:
            navigatorStrategy.setNavigator(new WalkingStrategy());
            break;
    }

    string Origin = "Ha noi";
    string Destination = "Ho Chi Minh";
    navigatorStrategy.Go(Origin, Destination);
}

