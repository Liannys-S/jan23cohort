
import java.util.Date;
import java.text.SimpleDateFormat;  
public class AlfredQuotes {
    
    public String basicGreeting() {
        // You do not need to code here, this is an example method
        return "Hello, lovely to see you. How are you?";
    }
    
    public String guestGreeting(String name) {
        // YOUR CODE HERE
        String timeOfDay = getTimeOfDay(); 
        return String.format("Good %s, %s. Lovely to see you", timeOfDay, name);
    }
    public String guestGreeting(String name, String dayPeriod) {
        // YOUR CODE HERE
        return String.format("Good %s, %s. Lovely to see you",dayPeriod, name);
    }
    
    public String dateAnnouncement() {
        Date date = new Date();
        return "It is currently " + date;
    }
    
    public String respondBeforeAlexis(String conversation) {
        if(conversation.contains("Alexis")){
            return "Right away, sir. She certainly isn't sophisticated enough for that.";
        }else if(conversation.contains("Alfred")){
            return "At your service. As you wish, naturally.";
        }else{
        return "Right. And with that I shall retire.";
        }
    }
    
    public String getTimeOfDay(){
        Date date = new Date();
        SimpleDateFormat formatter = new SimpleDateFormat("k");
        int hourOfDay = Integer.parseInt(formatter.format(date));
        if(hourOfDay >= 6 && hourOfDay < 12)
        {
            return "Morning";
        }else if(hourOfDay >= 12 && hourOfDay <= 18){
            return "Afternoon";
        }else{
            return "Evening";
        }
        
    }
	// NINJA BONUS
	// See the specs to overload the guestGreeting method
        // SENSEI BONUS
        // Write your own AlfredQuote method using any of the String methods you have learned!
}

