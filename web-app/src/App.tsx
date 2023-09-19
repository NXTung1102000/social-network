import { Provider } from "react-redux";
import { PersistGate } from "redux-persist/integration/react";
import { persistor, store } from "./service/redux/store";
import AppRouter from "./route/AppRouter";

function App() {
  return (
    // <Provider store={store}>
    //   <PersistGate loading={null} persistor={persistor}>
    <AppRouter />
    // </PersistGate>
    // </Provider>
  );
}

export default App;
