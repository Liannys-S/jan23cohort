import java.util.HashMap;
import java.util.Set;

public class TestHash{
    public static void main (String[] args){
        HashMap<String,String> trackList = new HashMap<String,String>();
        trackList.put("Sugar", "The Kombucha mushroom people \nSitting around all day \nWho can believe you?");
        trackList.put("Chop Suey", "Wake up (wake up)\nGrab a brush and put a little make-up");
        trackList.put("Toxicity", "Conversion, software version 7.0 \nLooking at life through the eyes of a tire hub");
        trackList.put("Lonely Day", "Such a lonely day, and it's mine \nThe most loneliest day of my life");

        String song = trackList.get("Sugar");
        System.out.println(song);

        System.out.println("----------------");

        Set<String> keys = trackList.keySet();
        for(String key : keys){
            System.out.printf("%s : %s%n%n", key, trackList.get(key));
        }
    }
}