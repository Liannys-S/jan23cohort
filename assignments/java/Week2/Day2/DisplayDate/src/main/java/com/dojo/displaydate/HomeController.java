package com.dojo.displaydate;

import java.text.SimpleDateFormat;
import java.util.Date;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class HomeController {
	@RequestMapping("/")
	public String index() {
		
		return "index.jsp";
	}
	
	@RequestMapping("/date")
	public String date(Model model) {
		Date date = new Date();
		SimpleDateFormat formatter = new SimpleDateFormat("EEEE MMM dd, yyyy");  
	    String strDate = formatter.format(date);  
		model.addAttribute("date", strDate);
		return "date.jsp";
		}
	
	@RequestMapping("/time")
	public String time(Model model)
	{
		Date date = new Date();
		SimpleDateFormat formatter = new SimpleDateFormat("h:mm a");  
	    String strTime = formatter.format(date); 
	    model.addAttribute("time", strTime);
		return "time.jsp";
	}
}
