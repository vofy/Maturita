public class TestDecorator {

 public static void main(String args[]) {
   IZmrzlina zmrzlina = new Zmrzlina(); 
   IZmrzlina sPolevou = new PolevaDekorator(zmrzlina);
   IZmrzlina sPolevouMedem = new MedDekorator(sPolevou);
   IZmrzlina seVsim = new SlehackaDekorator(new PolevaDekorator(new MedDekorator(new Zmrzlina())));
   System.out.println(zmrzlina.vyrobZmrzlinu());
   System.out.println(sPolevou.vyrobZmrzlinu());
   System.out.println(sPolevouMedem.vyrobZmrzlinu());
   System.out.println(seVsim.vyrobZmrzlinu());
 } 
}