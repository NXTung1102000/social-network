import { BrowserRouter, Route, Routes } from "react-router-dom";
import NotFound from "../page/NotFound";
import Home from "../page/Home";

const AppRouter = () => {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="*" element={<NotFound />} />
      </Routes>
    </BrowserRouter>
  );
};

export default AppRouter;
