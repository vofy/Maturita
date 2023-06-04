public class SlehackaDekorator extends DekoratorZmrzliny {

 public SlehackaDekorator(IZmrzlina specialniZmrzlina) {
   super(specialniZmrzlina);
 }

 public String vyrobZmrzlinu() {
   return specialniZmrzlina.vyrobZmrzlinu() + pridejSlehacku();
 }
 
 private String pridejSlehacku() {
   return " + kopec šlehačky";
 }
}