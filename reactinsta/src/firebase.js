import firebase from "firebase";

const firebaseConfig = {
    apiKey: "AIzaSyCe2Xtnn9Fisr4omQyPvxkJEHeH1IJnXR4",
    authDomain: "reactinsta-b6fe0.firebaseapp.com",
    projectId: "reactinsta-b6fe0",
    storageBucket: "reactinsta-b6fe0.appspot.com",
    messagingSenderId: "664061388186",
    appId: "1:664061388186:web:a11283b434c299f8e04623"
  };

  const firebaseApp = firebase.initializeApp(firebaseConfig);

  const db = firebaseApp.firestore();
  const auth = firebase.auth();
  const storage = firebase.storage();
  const provider = new firebase.auth.GoogleAuthProvider();
  
  export { db, auth, storage };
