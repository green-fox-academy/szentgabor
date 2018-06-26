import java.util.List;

public class WordFrequency {

  public static void main(String[] args) {
  	//1. Write the selectWordsByFrequency method to find the needed words
    List<String> selectedWords = selectWordsByFrequency("input.txt", 2);

    //2. Write the saveSelectedWords method to save the selected words
    saveSelectedWords("output.txt", selectedWords);
  }
}
