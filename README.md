![F1Sharp](https://raw.githubusercontent.com/gvescu/f1-sharp/main/f1sharp-logo.png)

# F1Sharp

Receive and parse the telemetry packets from the F1® 23 game.

Current UDP specification can be found [here](https://answers.ea.com/t5/General-Discussion/F1-23-UDP-Specification/td-p/12632888).

Since the specification changes every year and for scope reasons, this library is only compatible with F1® 23.

# Installing

This package is available on [NuGet](https://www.nuget.org/packages/F1Sharp/) now.

## Usage

### Enabling telemetry

UDP telemetry must be turned on in your game for this library to work. You can find the telemetry settings in `Options > Settings > Telemetry Settings` (F1® 23).

By default the `UDP Telemetry` option it's off, so you have to turn it on. While you're here you can also change the `UDP Port` setting if needed. The default is `20777`.

### Instancing client

For receiving the events you have to create an instance of `TelemetryClient`.

```csharp
// Instance the client listening on port 20777 (the default)
TelemetryClient client = new TelemetryClient(20777);
```

This instance has events that you can hook into for managing the data updates coming from the game.

```csharp
// Hook a method to the OnCarTelemetryDataReceive event
// This event represents whenever a packet is received that involves car telemetry (current speed, throttle or brake applied, engine RPM, etc.)
client.OnCarTelemetryDataReceive += Client_OnCarTelemetryDataReceive;

private void Client_OnCarTelemetryDataReceive(CarTelemetryPacket packet)
{
	// Get the player index from the list of cars in the session
	int playerIndex = packet.header.playerCarIndex;

	// Select the player's car from the list of car telemetries
	CarTelemetryData carTelemetryData = packet.carTelemetryData[playerIndex];

	// Write to console the engine RPM
	Console.WriteLine($"Engine RPM: {carTelemetryData.engineRPM}");
}
```

### Data binding

There are ViewModels included for a few of the data types for making it easier to use in GUI projects.

The ones included for now are for the following packets:

- Car Damage
- Car Setup
- Car Status
- Car Telemetry
- Lap Data
- Participants
- Session

Plus a global `UDPTelemetry` ViewModel for grouping all of them.

Example coming soon.

## Aknowledgements

Thanks a lot to [@thomz](https://github.com/thomz12) for coding the [library](https://github.com/thomz12/F12020-Telemetry) that inspired this one.

## Support

[Buy me a pizza](https://www.buymeacoffee.com/gvescu)

## Legal notice
F1® 23 Game - an official product of the FIA Formula One World Championship™.

The F1 Formula 1 logo, F1 logo, Formula 1, F1, FIA FORMULA ONE WORLD CHAMPIONSHIP, GRAND PRIX and related marks are trademarks of Formula One Licensing BV, a Formula 1 company. © 2023 Cover images Formula One World Championship Limited, a Formula 1 company. Licensed by Formula One World Championship Limited. The F2 FIA Formula 2 CHAMPIONSHIP logo, FIA Formula 2 CHAMPIONSHIP, FIA Formula 2, Formula 2, F2 and related marks are trademarks of the Federation Internationale de l’Automobile and used exclusively under licence.  All rights reserved. The FIA and FIA AfRS logos are trademarks of Federation Internationale de l’Automobile. All rights reserved.
