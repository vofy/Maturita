abstract class DekoratorZmrzliny implements IZmrzlina {

 protected IZmrzlina specialniZmrzlina;

 public DekoratorZmrzliny(IZmrzlina specialniZmrzlina) {
   this.specialniZmrzlina = specialniZmrzlina;
 }

 public String vyrobZmrzlinu() {
   return specialniZmrzlina.vyrobZmrzlinu();
 }
}