import java.text.*;

public record Point(int x, int y) {}

public class SandboxClass {
    public static void main(String[] args) {
        String[] nameArray = {"Joe", "Jim", "Mike Jordan"};
        System.out.println("Welcome to the Sandbox.");
        Utils.printArray(nameArray);
        String[] newNameArray = new String[2];
        System.arraycopy(nameArray, 0, newNameArray, 0, 2);
        Utils.printArray(newNameArray);

        // Setting current day to Monday
        Utils.DayOfWeek today = Utils.DayOfWeek.MONDAY;
        System.out.println(today);

        Point defaultPoint = new Point(1, 2);
        System.out.println(defaultPoint.toString());

        System.out.println(new DecimalFormat("###,###.##").format(1796.234));
    }
}

public class Utils {
    public enum DayOfWeek {
        MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY
    }

    public static void printArray (String[] array) {
        for (String string : array) {
            System.out.println(string);
        }
    }
}
