public class PolevaDekorator extends DekoratorZmrzliny {

 public PolevaDekorator(IZmrzlina specialniZmrzlina) {
   super(specialniZmrzlina);
 }

 public String vyrobZmrzlinu() {
   return specialniZmrzlina.vyrobZmrzlinu() + pridejPolevu();
 }
 
 private String pridejPolevu() {
   return " + Borůvková poleva";
 }
}