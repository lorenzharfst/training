/*
 * Car is $2.00
 * Taxi is $3.50
 * Bus is $5.00
 * DeliveryTruck is $10.00
 */

using ConsumerVehicleRegistration;
using CommercialRegistration;
using LiveryRegistration;

namespace Calculators;

public class TollCalculator
{
    private enum TimeBand {
        MorningRush,
        Daytime,
        EveningRush,
        Nighttime
    }

    public decimal CalculateToll(object vehicle) => vehicle switch
    {
        Car c => c.Passengers switch
        {
            0 => 2.00m + 0.50m,
            1 => 2.00m,
            2 => 2.00m - 0.50m,
            _ => 2.00m - 1.00m
        },
        Taxi t => t.Fares switch
        {
            0 => 2.00m + 0.50m,
            1 => 2.00m,
            2 => 2.00m - 0.50m,
            _ => 2.00m - 1.00m
        },
        Bus b when ((double)b.Passengers / (double)b.Capacity) < 0.50 => 5.00m + 2.00m,
        Bus b when ((double)b.Passengers / (double)b.Capacity) > 0.90 => 5.00m - 1.00m,
        Bus           => 5.00m,
        DeliveryTruck => 10.00m,
        { }           => throw new ArgumentException(message: "Unknown vehicle type", paramName: nameof(vehicle)),
        null          => throw new ArgumentNullException(nameof(vehicle))
    };

    private static TimeBand GetTimeBand(DateTime timeOfToll) => timeOfToll.Hour switch
    {
        < 6 or > 19         => TimeBand.Nighttime,
        < 10                => TimeBand.MorningRush,
        < 16                => TimeBand.Daytime,
        _                   => TimeBand.EveningRush
    };

    private static bool IsWeekDay(DateTime date) => date.DayOfWeek switch
    {
        DayOfWeek.Saturday  => false,
        DayOfWeek.Sunday    => false,
        _                   => true
    };

    public decimal AddPeakTimeFee(DateTime date, bool direction, decimal fee) =>
    (GetTimeBand(date), IsWeekDay(date), direction)
    {
        _, false, _             => fee,
        TimeBand.Daytime, true, _        => fee * 1.50m,
        (TimeBand.MorningRush or TimeBand.EveningRush), true, _   => fee * 2.00m,
        TimeBand.Nightime, true, _       => fee * 0.75m
    };
}

